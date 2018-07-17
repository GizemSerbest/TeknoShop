﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoSatis.Models
{
   public class Product
    {
        public int  ProductID { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsInStore{ get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}
