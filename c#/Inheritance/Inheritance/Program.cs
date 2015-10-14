using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
      static void FullName(Employee name)
        {
            Console.WriteLine("{0} {1}",name.FirstName,name.LastName);
            Debug.Assert(name != null, name.FirstName, name.LastName);
        }


            static void Main(string[] args)
        {
                var Hr = new Employee[]
                {
                new FullTimeEmployee {FirstName="Mike", LastName="Harrison", Years= 5 },
                new ContractEmployee {FirstName="Sally",LastName="Williams", Months = 2},                
                };
            foreach (var name in Hr)
            {
                FullName(name);
            }

                        Console.ReadLine();
        }
        }
}
