using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var Animal = new Animal[]
            {
                new Bear("bear"),
                new Chicken("chicken"),
                new Eagle("eagle")

            };

            foreach( var ani in Animal)
            {
                Console.WriteLine("the {0} goes", ani.Name);
                AnimalUtility.doSomething(ani);
             }

            if (Animal[2] is IBird)
            {
                Console.WriteLine("Flap Flap Flap");
            }
            Console.ReadLine();
        }
    }
}
