using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
     }

    public class FullTimeEmployee : Employee
    {
        public decimal Years { get; set; }

     }
    public class ContractEmployee : Employee
    {
        public decimal Months { get; set; }
    }
}
