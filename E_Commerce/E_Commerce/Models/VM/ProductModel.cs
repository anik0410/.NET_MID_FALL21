using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_commerce.Models.VM
{
    public class ProductModel
    {
        

        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

       
    }
}