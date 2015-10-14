using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Customer
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set {

                if (value < 0)
                {
                    //Debug.Assert(value == 0, FirstName,"cannot be younger than 0");
                    _age = 0;
                }else {
                    _age = value;
                }
                  
            }
        }

        public DateTime Born { get; set; }
    }
}
