using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;
using TeknoSatis.Services.Abstracts;

namespace TeknoSatis.Services.Concretes
{
    class CustomerRepo : IRepo<Customer>
    {
        TeknoContext teknoContext = new TeknoContext();
        public void Add(Customer customer)
        {
            teknoContext.Customers.Add(customer);
            teknoContext.SaveChanges();
        }

        public List<Customer> Get()
        {
            return teknoContext.Customers.ToList();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
