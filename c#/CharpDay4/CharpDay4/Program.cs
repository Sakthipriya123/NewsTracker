using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpDay4
{
    class Program
    {

        //static void ShowMessage(string message)
        //{
        //    if (String.IsNullOrEmpty(message))
        //    {
        //        throw new ArgumentNullException("message","you fool!");
        //    }
        //    Console.WriteLine(message);
        //}


        static void Main(string[] args)
        {

            // create bitmap
            using (var bitmap = new Bitmap(500, 500))
            {
                // randomly set 1000 pixels
                var rnd = new Random();
                for (var i = 0; i < 1000; i++)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Red);
                }
                // save bitmap to current directory (debug directory)
                var currentDirectory = Environment.CurrentDirectory;
                var path = Path.Combine(currentDirectory, "MyImage.png");

                bitmap.Save(path, ImageFormat.Png);
            } 
           

            Console.ReadLine();

            //try and catch


            //    var con = new SqlConnection("Data Source=MyDb;Database=myDb;username=stephen;pwd=Secret123");

            //    try
            //    {
            //        con.Open();
            //        //uese con to get data
            //    }
            //    catch
            //    {
            //        Console.WriteLine("could not connect to db");
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }

            //    using (con)
            //    {
            //        con.Open();
            //        //get data
            //    }

            //    Console.ReadLine();
            //}


            //try
            //{
            //    File.AppendAllText(@"c:\Nots.txt","Hello World");
            //}catch
            //{
            //    Console.WriteLine("cound not create Notes.txt file");
            //}


            //==============================================

            //var customer = new Customer("Priya","Shanmugam");
            //Console.WriteLine("{0} {1}", customer.FirstName, customer.LastName);
            //var customer1 = new Customer("", "shan");
            //Console.WriteLine("{0} {1}", customer1.FirstName, customer1.LastName);
            ////var customer2 = new Customer( "shanmugam");
            //Console.ReadLine();







            //=====================================================


            ////About Exceptions

            //ShowMessage("");


            //===========================================================================
            // //checking Performance
            // var sw = new Stopwatch();

            // sw.Start();
            //var message = "";

            // for(int i = 0; i < 10000 ; i++)
            // {
            //     message += "Hello World";
            // }
            // sw.Stop();

            // Console.WriteLine(sw.ElapsedMilliseconds);

            // //using StringBuilder- it reads faster

            // sw.Reset();
            // sw.Start();
            // var sb = new StringBuilder();
            // for (int i = 0; i < 100000 ; i++)
            // {
            //     sb.Append("Hello World");
            // }
            // sw.Stop();

            // Console.WriteLine(sw.ElapsedMilliseconds);
            // Console.ReadLine();


        }
    }
}
