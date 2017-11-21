using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopEF.DAL
{
    public class Category
    {
        [Display(Name = "Kategori ID")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Bu alan gereklidir.")]
        [Display(Name = "Kategori Ad")]
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
