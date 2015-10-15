using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay3
{
    public static class StringExtension
    {
        // extension method
        //here the this statement using the extension staement
        public static string CleanUp(this String value)
        {
            return value.Trim().ToLower();
        }
        public static string GetRandom(this string[] value)
        {
            var rnd = new Random();
            var o = rnd.Next(value.Length);
            return value[o];
        }
    }
}
