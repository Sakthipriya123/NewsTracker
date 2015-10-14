using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class NewCars : ICars
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int YearsOfWarranty { get; set; }

    }

    public class UsedCar:ICars
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Age { get; set; }
    }
}
