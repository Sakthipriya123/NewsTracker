using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("IPhone",1000m,3,"Limited Quality");
            var product1 = new Product("Iphone6", 100m, 3);

            var display = String.Format("{0} {1} {2} {3}",product.Name, product.Price, product.UnitInStock,product.Description);
            Console.WriteLine(display);
            Console.ReadLine();
        }
    }
}
