using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var words = new List<string>();
            words.Add("darn");
            words.Add("gosh");
            words.Add("yuck");

            foreach (var word in words)
            {
               ProfanityCleaner.Clean(word.ToLower());
               
            }
         
            Console.ReadLine();   
        }
    }
}
