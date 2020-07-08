using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models
{
    public class Brands
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name!")]
        public string Name { get; set; }
    }
}
