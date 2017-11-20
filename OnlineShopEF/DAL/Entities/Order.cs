using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShopEF.DAL
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }
    }
}
