using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Product
    {
        public Product(string code, string name, string quantity):this()
        {
            Code = code;
            this.name = name;
            Quantity = quantity;
        }

        public Product()
        {
        }

        public string Code { get; set; }
        public string name { get; set; }
        public string  Quantity { get; set; }
      
    }
}