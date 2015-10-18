using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDay4
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string fName, string lName)
        {
            if(string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                throw new ArgumentNullException("message", "never assign empty string to firstname and last name");
            }
            if (string.IsNullOrEmpty(lName))
            {
                throw new ArgumentNullException("message", "never leave empty the last name");
            }
            
            this.FirstName = fName;
            this.LastName = lName;


        }
    }
}
