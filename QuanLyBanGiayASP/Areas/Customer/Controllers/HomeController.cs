using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Extensions;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Models.ViewModels;

namespace QuanLyBanGiayASP.Controllers
{ 
    [Area("Customer")]
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ShopViewModels ShopVM { get; set; }
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
            ShopVM = new ShopViewModels()
            {
                Products = new List<Models.Products>(),
                Brands = new List<Models.Brands>(),
                typeProducts = new List<Models.TypeProduct>(),
            };
        }

        public IActionResult Index()
        {
            var productList = _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Include(m => m.TypeProduct).ToList();
            for (int i = 0; i < productList.Count; i++)
            {
                ShopVM.Products.Add(productList[i]);
            }
            return View(ShopVM);
        }
        public async Task<IActionResult> Details(int id)
        {
            var product = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(m => m.ID == id).FirstOrDefaultAsync();

            return View(product);
        }

        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetailsPost(int id,int Amount)
        {
            //list của 1 class lưu trong phương thức session, trong class này gồm id của product và số lượng của nó khi ta muốn đặt hàng
            //class này được tạo thành 1 list trong phương thức sesion có tên là ssShoppingCart 
            //(bth lưu id của product thì ở đây vì mỗi lần khách hàng có số lượng đặt hàng nên ta tạo 1 viewmodel tên là AmountProduct để lưu lại số lượng khi đặt)
            List<Amount_Product> lstShoppingCart = HttpContext.Session.Get<List<Amount_Product>>("ssShoppingCart");
            if (lstShoppingCart == null)
            {
               
                lstShoppingCart = new List<Amount_Product>();
            }
            lstShoppingCart.Add(new Amount_Product()
            {
                IDProduct = id,
                Amount = Amount
            }) ;
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction("Index", "Shop", new { area = "Customer" });

        }

        public IActionResult Remove(int id)
        {
            List<Amount_Product> lstShoppingCart = HttpContext.Session.Get<List<Amount_Product>>("ssShoppingCart");
            if (lstShoppingCart.Count > 0)
            {
                foreach (Amount_Product item in lstShoppingCart)
                {
                    if(item.IDProduct == id)
                    {
                        lstShoppingCart.Remove(item);

                        break;
                    }
                }
              
            }

            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
