﻿using System;
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
    //Tạo Admin vs superAdmin, ngoài ra tạo được customer nằm trong resister
    [Authorize(Roles = SD.SuperAdminEndUser + "," + SD.AdminEndUser)]
    [Area("Admin")]
    public class AdminUsersController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AdminUsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var adminUserList = (IEnumerable<ApplicationUser>)(from u in _db.ApplicationUser
                                                               join ur in _db.UserRoles on u.Id equals ur.UserId
                                                               join r in _db.Roles on ur.RoleId equals r.Id
                                                               where (r.Name == "Super Admin" || r.Name == "Admin")
                                                               select u);
            return View(adminUserList.ToList());
        }

        //Get Edit
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }


        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ApplicationUser userFromDb = _db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
                userFromDb.Name = applicationUser.Name;
                userFromDb.PhoneNumber = applicationUser.PhoneNumber;

                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(applicationUser);
        }


        //Get Delete
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var userFromDb = await _db.ApplicationUser.FindAsync(id);
            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);
        }


        //Post Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(string id)
        {
            ApplicationUser userFromDb = _db.ApplicationUser.Where(u => u.Id == id).FirstOrDefault();
            userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);

            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}