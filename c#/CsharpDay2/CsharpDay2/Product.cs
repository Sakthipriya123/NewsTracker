using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay2
{
   public class Product
    {

        public decimal CalculatePrice()
        {
            return this.CalculatePrice(0.08m, 0);
        }

       public decimal CalculatePrice(decimal taxRate)
        {
            return this.CalculatePrice(taxRate, 0);
        }
       
        public decimal CalculatePrice(decimal taxRate,decimal discount)
        {
            return this.Price + (this.Price * taxRate) + discount;
        }
        
        
        
        //the first declartion with feild and property is propfull
        private decimal _price; //its a feild

        public decimal Price //this is the property 
        {
            get { return _price; }
            set {
                if(value < 0)
                {
                    throw new Exception("Price cannot be lesser than zero");
                }
                _price = value;

            }
        }

        public string Name { get; set; }
        public int UnitsInStock { get; set; }

    }   
}
