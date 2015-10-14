using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitInStock { get; set; }
        public string Description { get; set; }

        public Product(string fname,decimal price,int unit,string description = "")
        {
            this.Name = fname;
            this.Price = price;
            this.UnitInStock = unit;
            this.Description = description ;        
        }


    }
}
