using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemelet
{
    class Program
    {
        static void Main(string[] args)
        {
            var read = File.ReadAllText(@"C:\Users\Priya\Documents\FinalProjects\c#\Hemelet\Hemelet\bin\Debug\hemlet.txt");

            read = read.ToLower();

            var remove = new string[]
            {
                ";","?","'",",","-","[","]","!",".",":"

            };
            foreach (var symbol in remove)
            {
                read = read.Replace(symbol, "");
            }

            List<string> wordlist = read.Split(' ').ToList();

            var removeWords = new string[]
            {
                "you","and","is","i","the","as","was","this","that","am","will","an","us","it","to","be",
                "on","of","for","a","he","she","him","his","in","thus","hemlet","word","mine","give","take","made","whose",
                "those","were","here","upon","what","take","than","into","when","where","been","more","could","does","might","done"
            };

            foreach (var words in removeWords)
            {
                while (wordlist.Contains(words))
                {
                    wordlist.Remove(words);
                }
            }


            Dictionary<string, int> array = new Dictionary<string, int>();

            foreach (var item in wordlist)
            {
                if (item.Length > 3)
                {
                    if (array.ContainsKey(item))
                    {
                        array[item]++;
                    }
                    else
                    {
                        array[item] = 1;
                    }
                }
            }

            var sortedWordList = (from item in array
                                  orderby item.Value descending
                                  select item)
                                .ToDictionary(k => k.Key, k => k.Value);

            var count = 1;

            foreach (KeyValuePair<string, int> k in sortedWordList)
            {
                Console.WriteLine("{0} occured {1} times", k.Key,k.Value);
                    count++;
                    
                    if(count > 60)
                    {
                        break;
                    }
                }

                Console.ReadLine();
            }

        }
    }

