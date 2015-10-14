using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public Person()
        //{
        //    this.FirstName = "Jane";
        //    this.LastName = "Williams";
        //}

        //or

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
