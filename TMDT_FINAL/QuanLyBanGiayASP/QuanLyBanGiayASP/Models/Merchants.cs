using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models
{
    public class Merchants
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name!")]
        public String Name_merchant { get; set; }
        [Required(ErrorMessage = "Enter Address!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Phone!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter Description!")]
        public string Description { get; set; }
    }
}
