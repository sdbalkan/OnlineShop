using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF.DAL
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
