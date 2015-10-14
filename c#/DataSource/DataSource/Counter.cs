using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    class Counter
    {
        public static void CountWords(string sentence)
        {
             int count = sentence.Count();
             Console.WriteLine(count);
        }
    }
}
