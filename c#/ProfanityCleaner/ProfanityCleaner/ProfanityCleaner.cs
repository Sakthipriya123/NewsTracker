using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfanityCleaner
{
    class ProfanityCleaner
    {
        public static void Clean(string w)
        {
            //var badWords = new Dictionary<string, string>();
            //badWords.Add("darn", "d**n");
            //badWords.Add("gosh", "gosh");
            //badWords.Add("yuck", "y**k");// not needed , ned to be declare in profinity cleaner class



            var replace = w.Replace("a", "*").Replace("u", "*").Replace("s", "*").Replace("o", "*").Replace("u", "*").Replace("c", "*").Replace("r", "*");
            Console.WriteLine(replace);

        }


    }
}
