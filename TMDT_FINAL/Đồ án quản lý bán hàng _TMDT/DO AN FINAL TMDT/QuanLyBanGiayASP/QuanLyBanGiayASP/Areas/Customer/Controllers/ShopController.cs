﻿using System;
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
                Brands = new List<Models.Brands>(),
                typeProducts= new List<Models.TypeProduct>(),
            };
        }
        //public async Task<IActionResult> best(string searchName = "PRO")
        //{
        //    System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        //    var claimsIdentity = (ClaimsIdentity)this.User.Identity;
        //    var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
        //    StringBuilder param = new StringBuilder();


        //    param.Append("&searchName=");

        //    if (searchName != null)
        //    {
        //        param.Append(searchName);
        //    }


        //    int count = 0;
        //    var productList = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).ToListAsync();
        //    var brandlist = await _db.Brands.ToListAsync();


        //    if (searchName != null)
        //    {
        //        productList = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(a => a.TypeProduct.TypePro.Contains(searchName.ToLower())).ToListAsync();

        //        for (int i = 0; i < productList.Count; i++)
        //        {
        //            ShopVM.Products.Add(productList[i]);
        //            count++;
        //        }
        //    }
        //    for (int i = 0; i < brandlist.Count; i++)
        //    {
        //        ShopVM.Brands.Add(brandlist[i]);
        //    }
        //    HttpContext.Session.Set("ssAmount", count);

        //    return View(ShopVM);
        //}

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
            var productList = await _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(m => m.Available == true).ToListAsync();
            var brandlist = await _db.Brands.ToListAsync();
            var typeProduct = await _db.TypeProducts.ToListAsync();


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
            for (int i = 0; i < typeProduct.Count; i++)
            {
                ShopVM.typeProducts.Add(typeProduct[i]);
            }
            HttpContext.Session.Set("ssAmount", count);

            return View(ShopVM);
            //return RedirectToAction("Index", "ssAmount");

        }
        public async Task<IActionResult> SearchIndex(String searchName )
        {

            var list = from m in _db.Products
                       select m;
            if(searchName!=null)
            {
                list = list.Where(s => s.Name.Contains(searchName));
            }
            return View(await list.ToListAsync());

        }

        public async Task<IActionResult> Search(int id)
        {

            int count = HttpContext.Session.Get<int>("ssAmount");
            count = 0;
            var productList = _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Where(a => a.BrandId == id).ToList();
            var brandlist = _db.Brands.ToList();
            var typeProduct = _db.TypeProducts.ToList();
            for (int i = 0; i < productList.Count; i++)
            {
                ShopVM.Products.Add(productList[i]);
                count++;
            }
            for (int i = 0; i < brandlist.Count; i++)
            {
                ShopVM.Brands.Add(brandlist[i]);
            }
            for (int i = 0; i < typeProduct.Count; i++)
            {
                ShopVM.typeProducts.Add(typeProduct[i]);
            }
            HttpContext.Session.Set("ssAmount", count);
            return View(ShopVM);

        }

        public async Task<IActionResult> SearchType(int id)
        {

            int count = HttpContext.Session.Get<int>("ssAmount");
            count = 0;
            var productList = _db.Products.Include(m => m.Merchants).Include(m => m.Brands).Include(m=>m.TypeProduct).Where(m=>m.TypeProduct.ID == id).ToList();
            var brandlist = _db.Brands.ToList();
            var typeProduct = _db.TypeProducts.ToList();
            for (int i = 0; i < productList.Count; i++)
            {
                ShopVM.Products.Add(productList[i]);
                count++;
            }
            for (int i = 0; i < brandlist.Count; i++)
            {
                ShopVM.Brands.Add(brandlist[i]);
            }
            for (int i = 0; i < typeProduct.Count; i++)
            {
                ShopVM.typeProducts.Add(typeProduct[i]);
            }
            HttpContext.Session.Set("ssAmount", count);
            return View(ShopVM);

        }
    }
}