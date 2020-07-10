using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Models.ViewModels;
using QuanLyBanGiayASP.Utility;


namespace QuanLyBanGiayASP.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser +"," +SD.AdminEndUser)]
    [Area("Admin")]

    public class AdminPageController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminPageController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            DashBoardViewModels dassboard = new DashBoardViewModels();
            var customerslist = (IEnumerable<ApplicationUser>)(from u in _db.ApplicationUser
                                                               join ur in _db.UserRoles on u.Id equals ur.UserId
                                                               join r in _db.Roles on ur.RoleId equals r.Id
                                                               where (r.Name == "Customer")
                                                               select u);
            dassboard.Brand_Count = _db.Brands.Count();
            dassboard.Customer_Count = customerslist.Count();
            dassboard.Order_Count = _db.Orders.Count();
            dassboard.Product_Count = _db.Products.Count();
            return View(dassboard);
        }
    }
}