using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoSatis.Models
{
   public class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
