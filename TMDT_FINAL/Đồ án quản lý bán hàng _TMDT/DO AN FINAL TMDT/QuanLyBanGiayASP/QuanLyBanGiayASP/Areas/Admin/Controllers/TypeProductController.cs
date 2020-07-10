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
    [Authorize(Roles = SD.SuperAdminEndUser + "," + SD.AdminEndUser)]
    [Area("Admin")]
    public class TypeProductController : Controller
    {
       
       
            private readonly ApplicationDbContext _db;
            public TypeProductController(ApplicationDbContext db)
            {
                _db = db;
            }
            public IActionResult Index()
            {
                return View(_db.TypeProducts.ToList());
            }

            //GET Create Action Method
            public IActionResult Create()
            {
                return View();
            }

            //POST Create action Method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(TypeProduct typeProducts)
            {
            if (ModelState.IsValid)
            {
                _db.Add(typeProducts);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                
                return View(typeProducts);
            }


        ////GET Edit Action Method
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeproduct = await _db.TypeProducts.FindAsync(id);
            if (typeproduct == null)
            {
                return NotFound();
            }

            return View(typeproduct);
        }

        //POST Edit action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypeProduct typeProduct)
        {
            if (id != typeProduct.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(typeProduct);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeProduct);
        }

        //GET Details Action Method
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typePro = await _db.TypeProducts.FindAsync(id);
            if (typePro == null)
            {
                return NotFound();
            }

            return View(typePro);
        }


        //GET Delete Action Method
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _db.TypeProducts.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        //POST Delete action Method
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brand = await _db.TypeProducts.FindAsync(id);
            _db.TypeProducts.Remove(brand);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }

}