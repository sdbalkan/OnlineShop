using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }

        public int OrderID { get; set; }

        public int LineNo { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
