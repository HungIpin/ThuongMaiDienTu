using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanGiayASP.Data;
using QuanLyBanGiayASP.Models.ViewModels;
using QuanLyBanGiayASP.Utility;


namespace QuanLyBanGiayASP.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.SuperAdminEndUser)]
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
            dassboard.Brand_Count = _db.Brands.Count();
            dassboard.Customer_Count = _db.Customers.Count();
            dassboard.Order_Count = _db.Orders.Count();
            dassboard.Product_Count = _db.Products.Count();
            return View(dassboard);
        }
    }
}