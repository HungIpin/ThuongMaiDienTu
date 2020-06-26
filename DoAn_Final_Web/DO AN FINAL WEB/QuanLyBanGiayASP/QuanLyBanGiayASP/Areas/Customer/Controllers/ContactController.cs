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


namespace QuanLyBanGiayASP.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class ContactController : Controller
    {    

        private readonly ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}