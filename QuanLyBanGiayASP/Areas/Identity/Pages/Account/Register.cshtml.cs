using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Logging;
using MimeKit;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Utility;

namespace QuanLyBanGiayASP.Areas.Identity.Pages.Account
{
    //Nếu như đăng nhập vs quyền SuperAdmin thì checkbox admin đc mở ra cho chọn superadmin hay admin, ngoài nếu ko đc đăng nhập bằng quyền supperadmin thì cũng đc tạo như 1 customer
    //[Authorize(Roles = SD.SuperAdminEndUser + "," + SD.Customer)]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required, Display(Name = "Họ và tên")]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "{0} tối thiểu {2} và tối đa {1} kí tự.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Mật khẩu")]

            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Xác nhận mật khẩu")]
            [Compare("Password", ErrorMessage = "Mật khẩu và xác nhận mật khẩu không chính xác.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "Số điện thoại")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Địa chỉ")]
            public string Address { get; set; }

            [Display(Name = "Tài khoản quản lý")]
            public bool IsSuperAdmin { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, Name = Input.Name, PhoneNumber = Input.PhoneNumber, Address = Input.Address };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if (User.IsInRole(SD.SuperAdminEndUser))
                    {
                        if (!await _roleManager.RoleExistsAsync(SD.AdminEndUser))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(SD.AdminEndUser));
                        }
                        if (!await _roleManager.RoleExistsAsync(SD.SuperAdminEndUser))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(SD.SuperAdminEndUser));
                        }
                        if (Input.IsSuperAdmin)
                        {
                            await _userManager.AddToRoleAsync(user, SD.SuperAdminEndUser);
                        }
                        else
                        {
                            await _userManager.AddToRoleAsync(user, SD.AdminEndUser);
                        }
                    }
                    else
                    {
                        if (!await _roleManager.RoleExistsAsync(SD.Customer))
                        {
                            await _roleManager.CreateAsync(new IdentityRole(SD.Customer));
                        }
                        await _userManager.AddToRoleAsync(user, SD.Customer);
                    }

                    //_logger.LogInformation("User created a new account with password.");

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    //return RedirectToAction("Index", "AdminUsers", new { area = "Admin" });

                    //if (!await _roleManager.RoleExistsAsync(SD.SuperAdminEndUser))
                    //{
                    //    await _roleManager.CreateAsync(new IdentityRole(SD.SuperAdminEndUser));
                    //}
                    //if (!await _roleManager.RoleExistsAsync(SD.AdminEndUser))
                    //{
                    //    await _roleManager.CreateAsync(new IdentityRole(SD.AdminEndUser));
                    //}
                    //if (!await _roleManager.RoleExistsAsync(SD.Customer))
                    //{
                    //    await _roleManager.CreateAsync(new IdentityRole(SD.Customer));
                    //}
                    //if (Input.IsSuperAdmin)
                    //{
                    //    await _userManager.AddToRoleAsync(user, SD.SuperAdminEndUser);
                    //}
                    //else
                    //{
                    //    await _userManager.AddToRoleAsync(user, SD.Customer);
                    //}
                    await _userManager.UpdateAsync(user);
                    _logger.LogInformation("User created a new account with password.");
                    string confirmationToken = _userManager.GenerateEmailConfirmationTokenAsync(user).Result;
                    string confirmationLink = Url.Action("ConfirmEmail",
                        "AccountConfirm", new { userId = user.Id, token = confirmationToken },
                        protocol: HttpContext.Request.Scheme);                  
                   
                    using (SmtpClient client = new SmtpClient())
                    {
                        var message = new MimeMessage();
                        message.From.Add(new MailboxAddress("Verify", "conaldo001@gmail.com"));
                        message.To.Add(new MailboxAddress("Not Reply", user.Email));
                        message.Subject = "Confirm your email and be with us";
                        message.Body = new TextPart(MimeKit.Text.TextFormat.Text)
                        { Text = "You have register an account, using this your email: " + user.Email + " and registed password to login " + Environment.NewLine + confirmationLink };
                        client.Connect("smtp.gmail.com", 465, true);
                        client.Authenticate("conaldo001@gmail.com", "Cuong16031999");
                        client.Send(message);
                        client.Disconnect(true);
                        return RedirectToPage("Login");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                
            }
            //else
            //{
            //    ModelState.AddModelError("SameUsername", "Tài khoản đã được đăng ký");
            //    return Page();
            //}

            // If we got this far, something failed, redisplay form
            return Page();
        }
       
    }
}
