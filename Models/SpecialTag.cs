using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApp.Models
{
    public class SpecialTag
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter tag name properly.")]
        [Display(Name="Tag Name")]
        public string  Name { get; set; }
    }
}
