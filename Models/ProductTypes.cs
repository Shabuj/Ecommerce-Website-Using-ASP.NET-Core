using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApp.Models
{
    public class ProductTypes
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Enter Product Type")]
        [Display(Name ="Product Type")]
        public string ProductType { get; set; }
    }
}
