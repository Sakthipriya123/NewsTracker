using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {

        static void DisplayCar(Car car)
        {
            Console.WriteLine("model:{0},price:{1:c}", car.Model, car.Price);
        }


        static void Main(string[] args)
        {
            var inventory = new Car[]
            {
                new UsedCar {Model="Tesla X", Age=1, Price = 888999m },
                new UsedCar {Model="Tesla M",Age=2,Price=898998m },
                new NewCar {Model="Tesla X",YearsUnderWarrenty=3,Price=76786m }
            };
            foreach(var car in inventory)
            {
                DisplayCar(car);
            }

        }
    }
}
