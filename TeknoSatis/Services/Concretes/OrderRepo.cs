using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;
using TeknoSatis.Services.Abstracts;

namespace TeknoSatis.Services.Concretes
{
    public class OrderRepo : IRepo<Order>
    {
        TeknoContext tekno = new TeknoContext();

        public void Add(Order order)
        {
            tekno.Orders.Add(order);
            tekno.SaveChanges();
        }

        public List<Order> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePrice(List<Product> list)
        {
            decimal total= 0;
            foreach (Product item in list)
            {
                total = item.UnitPrice + total;
            }

            return total;
        }
    }
}
