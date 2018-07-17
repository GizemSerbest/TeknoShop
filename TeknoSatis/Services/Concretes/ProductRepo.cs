using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;
using TeknoSatis.Services.Abstracts;

namespace TeknoSatis.Services.Concretes
{
    class ProductRepo : IRepo<Product>
    {
        TeknoContext teknoContext = new TeknoContext();
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> Get()
        {
            List < Product > products = teknoContext.Products.ToList();
            return products;
        }

        public void Update(Product product)
        {
            List<Product> products = Get();

            foreach (Product item in products)
            {
                if(item.ProductName == product.ProductName)
                {
                    item.UnitsInStore = item.UnitsInStore - 1;
                }
            }
            teknoContext.SaveChanges();
        }
    }
}
