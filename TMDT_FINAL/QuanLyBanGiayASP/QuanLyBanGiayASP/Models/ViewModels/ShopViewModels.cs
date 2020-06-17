using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models.ViewModels
{
    public class ShopViewModels
    {
        public List<Products> Products { get; set; }

        public PagingInfo PagingInfo { get; set; }
        public List<Brands> Brands { get; set; }
    }
}
