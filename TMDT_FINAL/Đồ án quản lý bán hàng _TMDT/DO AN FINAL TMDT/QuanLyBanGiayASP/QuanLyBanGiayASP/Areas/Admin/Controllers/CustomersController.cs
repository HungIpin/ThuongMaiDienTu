using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Models;
using QuanLyBanGiayASP.Utility;

namespace QuanLyBanGiayASP.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var customerlist = (IEnumerable<ApplicationUser>)(from u in _db.ApplicationUser
                                                              join ur in _db.UserRoles on u.Id equals ur.UserId
                                                              join r in _db.Roles on ur.RoleId equals r.Id
                                                              where (r.Name == "Customer")
                                                              select u);
            return View(customerlist.ToList());
        }
        

       
    }
}