using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validating
{
    class Program
     {
        public static decimal CalculateTotalPriceWithTax(decimal price,decimal taxRate)
        {
            if(price < 0 || taxRate < 0)
            {
                throw new ArgumentException("price and taxrate should not be less than zero", "price");
            }
            if(taxRate >= 10m)
            {
                throw new ArgumentException("taxrate should be less than 10%");
            }
            
                return (price + (price * taxRate));
            
        }

        static void Main(string[] args)
        {
            CalculateTotalPriceWithTax(1000m, 0.08m);
            Console.ReadLine();
        }
    }
}
