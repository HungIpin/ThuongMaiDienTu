using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models.ViewModels
{
    public class CustomerOrderViewModels
    {
        public List<Orders> Orders { get; set; }
        public List<Products> Products { get; set; }
    }
}
