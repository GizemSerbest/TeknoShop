using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;
using TeknoSatis.Services.Abstracts;

namespace TeknoSatis.Services.Concretes
{
    class OrderDetailRepo : IRepo<OrderDetail>
    {
        TeknoContext tekno = new TeknoContext();
        public void Add(OrderDetail item)
        {
            tekno.OrderDetails.Add(item);
            tekno.SaveChanges();
        }

        public List<OrderDetail> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetail item)
        {
            throw new NotImplementedException();
        }
    }
}
