using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Models.ViewModels;
using QuanLyBanGiayASP.Utility;

namespace QuanLyBanGiayASP.Areas.Customer.Controllers
{
    [Authorize(Roles = SD.Customer)]
    [Area("Customer")]
    public class CustomerOrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerOrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //Check user now
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            CustomerOrderViewModels orderVM = new CustomerOrderViewModels()
            {
                Orders = new List<Models.Orders>()
            };


            orderVM.Orders = _db.Orders.Include(s => s.CustomerPerson).ToList();

            orderVM.Orders = orderVM.Orders.Where(s => s.CustomerPersonId == claim.Value).ToList();
            return View(orderVM);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productList = (IEnumerable<Products>)(from p in _db.Products
                                                      join a in _db.OrderItems
                                                      on p.ID equals a.ProductID
                                                      where a.OrderID == id
                                                      select p).Include("Merchants").Include("Brands");

            OrderDetailViewModels objOrderVM = new OrderDetailViewModels()
            {
                Order = _db.Orders.Include(a => a.Customers).Include(a => a.OrderItems)
                      .Where(a => a.ID == id).FirstOrDefault(),
                Products = productList.ToList()
            };

            return View(objOrderVM);
        }
    }
}