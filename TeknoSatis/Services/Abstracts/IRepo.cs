using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoSatis.Services.Abstracts
{
    interface IRepo<T>
    {
        void Add(T item);
        void Update(T item);
        List<T> Get();


    }
}
