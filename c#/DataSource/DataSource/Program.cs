using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataSource
{
    class Program
    {

        public static string RandomStr()

        {
            //The GetRandomFileName method returns a cryptographically strong, random string that can be used as either a folder name or a file name
            string rStr = Path.GetRandomFileName();
            rStr = rStr.Replace(".", ""); // For Removing the .
            return rStr;
        }

        public static string FileData()
        {
            //Read the file as one string.
            string text =File.ReadAllText(@"C:\Users\Priya\Documents\FinalProjects\c#\DataSource\DataSource\bin\Debug\text.txt");
            return text;
        }

        static void Main(string[] args)
        {
            var rnd = new Random();

            string sentence =RandomStr().ToString();
            Console.WriteLine(RandomStr());
            Counter.CountWords(sentence);

            string data = FileData().ToString();
            Console.WriteLine(FileData());
            Counter.CountWords(data);
            Console.ReadLine();    
            
    }
    }
}
