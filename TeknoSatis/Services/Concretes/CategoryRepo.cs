using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;
using TeknoSatis.Services.Abstracts;

namespace TeknoSatis.Services.Concretes
{
    class CategoryRepo : IRepo<Category>
    {

        TeknoContext teknoContext = new TeknoContext();
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            List<Category> categories = teknoContext.Categories.ToList();
            return categories;

        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
