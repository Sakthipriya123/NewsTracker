using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay2
{
    class Program
    {








        //static int AddNumbers(int val1,int val2)
        //{
        //    return val1 + val2;
        //}

        //static int AddNumbers(string val1, string val2)
        //{
        //    return int.Parse(val1) + int.Parse(val2);
        //}

        //static int AddNumbers(params int[] vals)
        //{
        //    var result = 0;
        //    foreach (var val in vals)
        //    {
        //        result += val;
        //    }
        //    return result;
        //}

        static void Main(string[] args)
        {

            var bob = new Person("Priya","Shanmugam");

            Console.WriteLine(bob.FirstName);
            Console.ReadLine();













            //if we give addNumbers(3,5,7,8) more arguments we have to use parameter array params int[]

            //var result = AddNumbers(3, 4);

            //var result = AddNumbers(3,3,4,6,6,7);
            //var result2 = AddNumbers("3", "22");
            //Console.WriteLine(result);

            //var productName = "laptop";
            //var productPrice = 3434.23m;

            ////in js we use backtec operator, here we can use sting.format instead of using this
            ////var message = productName + "cost" + productPrice.ToString("c");

            //var message = string.Format("{0} costs {1:c}",productName,productPrice);
            //Console.WriteLine(message);



            ////var tesla = new Product();
            ////tesla.Name = "Model X";
            ////tesla.Price = 120000;
            ////tesla.UnitsInStock = 2;

            //// the above one is older way, the below one is the newest way to declare the product


            //var tesla = new Product
            //{
            //    Name = "Model X",
            //    Price = 120000,
            //    UnitsInStock = 2

            //};

            ////here the taxrate is the named argument r parameter
            ////var price = tesla.CalculatePrice(taxRate:.05m);
            ////if we give without argument den we can declare the argument in the product class using the named space argument
            //var price = tesla.CalculatePrice();

            //Console.WriteLine("{0} costs {1:c}", tesla.Name, price);
            //Console.ReadLine();

        }
    }
}
