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
        //GET Edit
        public async Task<IActionResult> Edit(int? id)
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
                Order = _db.Orders.Include(a => a.Customers).Include(a => a.OrderItems).Include(a => a.SalerPerson)
                      .Where(a => a.ID == id).FirstOrDefault(),
                Products = productList.ToList()
            };
            return View(objOrderVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, OrderDetailViewModels objOrderVM)
        {
            if (ModelState.IsValid)
            {
                objOrderVM.Order.Date = objOrderVM.Order.Date
                                    .AddHours(objOrderVM.Order.Time.Hour)
                                    .AddMinutes(objOrderVM.Order.Time.Minute);
                var orderFromDb = _db.Orders.Where(a => a.ID == objOrderVM.Order.ID).FirstOrDefault();
                orderFromDb.Address = objOrderVM.Order.Address;
                orderFromDb.Customers = objOrderVM.Order.Customers;
                orderFromDb.Date = objOrderVM.Order.Date;
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(objOrderVM);
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
        //GET Delete
        public async Task<IActionResult> Delete(int? id)
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
                Order = _db.Orders.Include(a => a.Customers).Include(a => a.SalerPerson).Include(a => a.OrderItems).Where(a => a.ID == id).FirstOrDefault(),
                SalesPerson = _db.ApplicationUser.ToList(),
                Products = productList.ToList()
            };
            return View(objOrderVM);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _db.Orders.FindAsync(id);
            var customer = await _db.Customers.FindAsync(order.CustomerID);
            var tableCTOrder = _db.OrderItems.ToList();
            var tableProduct = _db.Products.ToList();
            foreach (var item in tableCTOrder)
            {
                if (item.OrderID == order.ID)
                {
                    var ctOrder = await _db.OrderItems.FindAsync(item.ID);
                    //Cập nhật lại số product trong kho nếu giao dịch không thành công
                    foreach (var product in tableProduct)
                    {
                        if (product.ID == ctOrder.ProductID)
                        {
                            int update = product.InStock + ctOrder.Amount;
                            var productDB = await _db.Products.FindAsync(ctOrder.ProductID);
                            productDB.InStock = update;
                            _db.Products.Update(productDB);
                        }
                    }
                    _db.OrderItems.Remove(ctOrder);
                }
            }
            _db.Customers.Remove(customer);
            _db.Orders.Remove(order);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}