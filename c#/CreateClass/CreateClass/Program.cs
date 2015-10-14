using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var sally = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = -23,
                Born = DateTime.Parse("10/13/2000")
            };

            var mike = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                Born = DateTime.Parse("01/04/2019")

            };

            Debug.Assert(sally.Age == 23, "Sally is 23.");
            Debug.Assert(mike.Age == 10, "Mike is 10.");

            
            Console.WriteLine("{0} {1} who is {2} years old, was born on {3}",mike.FirstName, mike.LastName,mike.Age,mike.Born.ToString());
            Console.WriteLine("{0} {1} who is {2} years old, was born on {3}", sally.FirstName, sally.LastName, sally.Age, sally.Born.ToString());
            Console.ReadLine();
        }
    }
}
