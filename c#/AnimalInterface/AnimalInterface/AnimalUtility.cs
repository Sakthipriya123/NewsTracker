using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class AnimalUtility
    {
        public static void doSomething(Animal animal)
        { 
            if(animal is IBird)
            {
                Console.WriteLine("flap flap flap");
            }

            Console.WriteLine(animal.MakeSound());
        }


    }
}
