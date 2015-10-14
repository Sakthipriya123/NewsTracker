using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Media;

namespace CSharpDay1
{
    class Program
    {

        /* this is for multiline comment*/


        //static int DivideNumbers(int val1,int val2)
        //{
        //    //Debug.Assert(val2 != 0, "val2 is not zero!");
        //    return val1 / val2;
        //}



        static void Main(string[] args)
        {

            //var message="";
            //for (int i=0; i<1000 ; i++){
            //message +="helloWorld";
            //}


            //var sb = new StringBuilder();
            //for(int i=0; i < 1000; i++)
            //{
            //    sb.Append("Hello World");
            //}

            //Console.WriteLine(sb.ToString());

            ////regular Expression
            //var re = new Regex(@"\d+");
            //Console.WriteLine("Enter your favorite number");
            //var input = Console.ReadLine();

            //if (re.IsMatch(input))
            //{
            //    Console.WriteLine("Its a Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not a number");
            //}


            ////Array

            //var fruit = new string[]
            //{
            //    "apples",
            //    "kiwis",
            //    "oranges"
            //};

            //var states = new string[99];
            //states[66] = "washington";

            //foreach(var thing in states)
            //{
            //    Console.WriteLine("-" + thing);
            //}



            //var news = new string[]
            //{
            //  "Life discovered  on Mars",
            //  "Seahawks wins SuperBowl",
            //  "Mostly Cloudy Today"

            //};

            //var rnd = new Random();
            //var output = rnd.Next(news.Length);
            //Console.WriteLine(news[output]);


            var news = new string[]
            {
              "Life discovered  on Mars",
              "Seahawks wins SuperBowl",
              "Mostly Cloudy Today"
            };

            for(int i=0;i <news.Length; i++)
            {
                Console.WriteLine(news[i]);
            }

            foreach(var item in news)
            {
                Console.WriteLine(item);
            }

            var player = new SoundPlayer[3];

             player[0] = new SoundPlayer("http://www.wavsource.com/snds_2015-10-11_5648730289231752/movies/12_angry_men/story.wav");
             player[1] = new SoundPlayer("http://www.wavsource.com/snds_2015-10-11_5648730289231752/movies/airplane/computer_blow.wav");
             player[2] = new SoundPlayer("http://www.wavsource.com/snds_2015-10-11_5648730289231752/movies/manhattan/deserve_better.wav");

            var rnd = new Random();
            var output = rnd.Next(player.Length);

            switch(output)
            {
                case 0:
                    player[0].Play();
                    break;

                case 1:
                    player[1].Play();
                    break;

                case 2:
                    player[2].Play();
                    break;

                
            }


            Console.ReadLine();



            //for declaring file path
            //var filePath = @"c:\someFile.txt";
            //or var filePath ="c:\\someFile.txt" ;

         //   var script = @"function doSomething(){
         //   console.write();
                
         //}";

         //   Console.WriteLine(script);

         //   var fixedMessag = "I love cake".Replace("cake", "whiskey");
         //   Console.WriteLine(fixedMessag);
         //   Console.ReadLine();

            //var price =34255255.87868876m;

            //Console.WriteLine(price.ToString("c"));


            //Console.WriteLine("enter your favourite number");
            //var stringNumber = Console.ReadLine();
            //var number = decimal.Parse(stringNumber);

            //Console.WriteLine(number * 10);



            // Console.WriteLine("enter the date");
            //var input = Console.ReadLine();
            //var output = DateTime.Parse(input.ToString());
            //Console.WriteLine(output.ToLongDateString());
            ////var output = DateTime.Parse(input);
            ////Console.WriteLine(output.Tostring("r"));
            //Console.ReadLine();


            //var result = DivideNumbers(1, 0);

            //this does something useful single line comment
            //if (File.Exists("c:\\SomeFile.txt"))
            //    Console.WriteLine("exists!");
            //else
            //    Console.WriteLine("nope!");

            //var rnd = new Random();
            //var number = rnd.Next(1, 11);
            //Console.WriteLine(number);
            //Console.WriteLine("Hello World");  


            //var localTime = DateTime.Now;
            //Console.WriteLine(localTime);
            //Console.ReadLine();

        }

        }
}
