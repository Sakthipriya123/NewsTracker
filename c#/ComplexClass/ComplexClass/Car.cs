using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public abstract class Car
    {
       public string Model { get; set; }
       public decimal Price { get; set; }

        public virtual void Honk()
        {
            Console.WriteLine("Honk");
        }

    }

    public class UsedCar : Car
    {
        public int Age { get; set; }

        public override void Honk()
        {
            Console.WriteLine("blurp...");
        }
    }
     public class NewCar : Car
    {
        public int YearsUnderWarrenty { get; set; }
    }
}
