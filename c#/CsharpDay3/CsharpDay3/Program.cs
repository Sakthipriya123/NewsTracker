using CsharpDay3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace CsharpDay3
{
    class Program
    {

        //class Product
        //{
        //    public string Name { get; set; }
        //    public decimal Price { get; set; }
        //}
        public async static Task doSomething()
        {
            var client = new HttpClient();
            var page = await client.GetStringAsync("http://shakespeare.mit.edu/hamlet/full.html");
            Console.WriteLine(page);
        }


        static void Main(string[] args)
        { 
            doSomething().Wait();
            Console.ReadLine();


            //var list = new List<Product>
            //{
            //    new Product {Name="Milk", Price=23.52m },
            //    new Product {Name="Cheese", Price=27.82m },
            //    new Product {Name="Eggs", Price=28.92m },
            //};
            

            //foreach(var product in list)
            //{
            //    Console.WriteLine(product.Name);
            //}

            ////var states = new Hashtable();

            ////states.Add("wa", "Washington");
            ////states.Add("ca", "California");
            ////states.Add(1, "Florida");

            ////Console.WriteLine(states[1]);//here 1 is the key value if we want california we have to give states["ca"]

            //Console.ReadLine();

            ////if we get red squiggly means we have to add namespace
            //var list = new ArrayList();
            ////its a list of anything
            //list.Add(new Product { Price = 34m });
            //list.Add(new Product { Price = 32m });
            //list.Add(new Product { Price = 49m });
            ////if we give
            //list.Add(989898);//throw an exception error(run time error)

            //var product = list[0];

            //foreach (var item in list)
            //{
            //    var prod = item as Product;
            //    Console.WriteLine(prod.Price);
                
            //}

            //Console.ReadLine();

            //var newsArray = new string[]
            //{
            //     "Martians Attack",
            //     "Seahawks win SuperBowl",
            //     "Seattle Weather"
            //};

            //Console.WriteLine(newsArray.GetRandom());
            //Console.ReadLine();



            //===================================================

            //Console.Write("Enter your Favorite Color");
            //var favoriteColor = Console.ReadLine();
            ////the cleanup method is the extension method
            //favoriteColor = favoriteColor.CleanUp();


            ////favoriteColor = Utility.CleanInput(favoriteColor);

            //Console.WriteLine(favoriteColor);
            //Console.ReadLine();


            // var prod = new Models.Product();
            //or we can use the models like using CharpDay3.Models
            //var prod = new Product();
        }
    }
}

