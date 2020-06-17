using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Extensions;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Models.ViewModels;

namespace QuanLyBanGiayASP.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ShopViewModels ShopVM { get; set; }
        public ShopController(ApplicationDbContext db)
        {
            _db = db;
            ShopVM = new ShopViewModels()
            {
                Products = new List<Models.Products>(),
                Brands = new List<Models.Brands>()
            };
        }

        public async Task<IActionResult> Index( string searchName = null)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            StringBuilder param = new StringBuilder();


            param.Append("&searchName=");

            if (searchName != null)
            {
                param.Append(searchName);
            }


            int count = 0;
            var productList = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).ToListAsync();
            var brandlist = await _db.Brands.ToListAsync();


            if (searchName != null)
            {
                productList = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(a => a.Name.ToLower().Contains(searchName.ToLower())).ToListAsync();

                for (int i = 0; i < productList.Count; i++)
                {
                    ShopVM.Products.Add(productList[i]);
                    count++;
                }
            }
            else
            {

                for (int i = 0; i < productList.Count; i++)
                {
                    ShopVM.Products.Add(productList[i]);
                    count++;
                }

            }
            for (int i = 0; i < brandlist.Count; i++)
            {
                ShopVM.Brands.Add(brandlist[i]);
            }
            HttpContext.Session.Set("ssAmount", count);
            
            return View(ShopVM);
        }
        public async Task<IActionResult> Search(int id)
        {
            int count = HttpContext.Session.Get<int>("ssAmount");
            var productList = _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(a => a.BrandId == id).ToList();
            var brandlist = _db.Brands.ToList();
            for (int i = 0; i < productList.Count; i++)
            {
                ShopVM.Products.Add(productList[i]);
                count++;
            }
            for (int i = 0; i < brandlist.Count; i++)
            {
                ShopVM.Brands.Add(brandlist[i]);
            }
            HttpContext.Session.Set("ssAmount", count);
            return View(ShopVM);

        }
    }
}