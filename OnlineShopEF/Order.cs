using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }

        public Customer Customer { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}
