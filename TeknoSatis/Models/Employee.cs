using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoSatis.Models
{
   public class Employee
    {
        public int EmployeeID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Authority Authority { get; set; }

    }
}
