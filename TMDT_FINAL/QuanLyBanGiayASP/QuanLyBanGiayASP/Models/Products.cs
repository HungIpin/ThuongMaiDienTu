using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Models
{
    public class Products
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name!")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Enter Price!")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Enter Avalable!")]
        public bool Available { get; set; }

        public string Image { get; set; }
        [Required(ErrorMessage = "Enter Description!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter Amount!")]
        public int InStock { get; set; }

        [Display(Name = "Merchant")]
        public int MerchantId { get; set; }

        [ForeignKey("MerchantId")]
        public virtual Merchants Merchants { get; set; }

        [Display(Name = "Brand")]
        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brands Brands { get; set; }
        public ICollection<ImportDetails> ImportDetails { get; set; }
    }
}
