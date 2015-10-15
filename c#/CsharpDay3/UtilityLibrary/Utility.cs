using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
   public class Utility
    {
        public static string CleanInput(string value)
        {
            return value.Trim().ToLower();
        }

        private static void DosomethingSecret()
        {
            //this can be used only within this class becos 
        }
    }

class Test
    {
        private void DoSomething()
        {
            //this is used within this class only ,will not able to use in utility class
        }
    }
}
