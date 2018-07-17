using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TeknoSatis.Models;

namespace TeknoSatis
{
   public class TeknoContext : DbContext
    {
        public TeknoContext()
        {
            Database.Connection.ConnectionString = @"server=.;database=TEKNODB;uid=sa;pwd=123456";
      }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        
    }
}
