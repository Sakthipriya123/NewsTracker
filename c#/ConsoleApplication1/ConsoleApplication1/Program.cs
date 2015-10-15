using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string sInput = "Hello World, This is a great World. I love this great World";
            sInput = sInput.Replace(",", ""); //Just cleaning up a bit
            sInput = sInput.Replace(".", ""); //Just cleaning up a bit
            string[] arr = sInput.Split(' '); //Create an array of words

            foreach (string word in arr) //let's loop over the words
            {
                if (word.Length >= 3) //if it meets our criteria of at least 3 letters
                {
                    if (dictionary.ContainsKey(word)) //if it's in the dictionary
                        dictionary[word] = dictionary[word] + 1; //Increment the count
                    else
                        dictionary[word] = 1; //put it in the dictionary with a count 1
                }
            }


            StringBuilder wordBuffer = new StringBuilder();
            int wordCount = 0;

            // 1. Build the list of words used. Consider ''' (apostrophe) and '-' (hyphen) a word continuation character.
            Dictionary<string, int> wordList = new Dictionary<string, int>();
            while (reader.Peek() >= 0)
            {
                char c = (char)reader.Read();

                if (char.IsLetter(c) || c == '\'' || c == '-')
                {
                    wordBuffer.Append(char.ToLower(c));
                }
                else
                {
                    if (wordBuffer.Length > 0)
                    {
                        int count = 0;
                        string word = wordBuffer.ToString();
                        wordList.TryGetValue(word, out count);
                        wordList[word] = ++count;

                        wordBuffer.Clear();
                        wordCount++;
                    }
                }
            }


            var words = wordList
                           //.split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Where(w => w.Value >= 3)
                           .GroupBy(w => w)
                          .OrderByDescending(g => g.Count());

            foreach (var word in words)
                Console.WriteLine("{0}x {1}", word.Count(), word.Key);

            // 2. Sort our dictionary.
            //var sortedWordList = from item in wordList
            //                     orderby item.Value descending
            //                     select item;

            //// 3. Print top 10 words and word count.
            //foreach (var item in sortedWordList.Take(60))
            //{
            //    Console.WriteLine("word: {0}, count: {1}", item.Key, item.Value);
            //}

            Console.WriteLine();
            Console.WriteLine("Total number of words: {0}", wordCount);

            Console.ReadLine();
        }
    }
}
  

            foreach (KeyValuePair<string, int> pair in dictionary) //loop through the dictionary
                Console.WriteLine(string.Format("Key: {0}, Pair: {1}<br />", pair.Key, pair.Value));
            Console.ReadLine();
        }
    }
}
