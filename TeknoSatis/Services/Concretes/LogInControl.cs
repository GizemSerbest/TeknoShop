using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknoSatis.Models;

namespace TeknoSatis.Services.Concretes
{
   public static class LogInControl
    {

        public static bool AutControl(string username, string password)
        {
            TeknoContext tekdb = new TeknoContext();

            List<Employee> dblist = tekdb.Employees.Where(x => x.UserName == username && x.Password == password).ToList();

            if (dblist.Count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }

           
        }
        public static Employee GetEmployee(string username, string password)
        {
            TeknoContext tekno = new TeknoContext();

            List<Employee> list = tekno.Employees.Where(x => x.UserName == username && x.Password == password).ToList();

            Employee employee = new Employee();

            employee = list[0];

            return employee;

        }
    }
}
