using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
