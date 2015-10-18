using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public static class DeckExtension
    {

        private static void CreateSuits(string face, int value, ref Dictionary<string, int> deck)
        {
            var Suits = new String[]
            {"Hearts",
             "Diamonds",
             "Clubs",
             "Spades"
            };

            foreach (var suit in Suits)
            {
                deck.Add(face + " of " + suit, value);
            }
        }

        public static Dictionary<string, int> CreateDeck(this Dictionary<string, int> deck)
        {

            for (int i = 1; i < 14; i++)
            {
                if (i == 1)
                {
                    CreateSuits("Ace", 1, ref deck);
                }
                else if (i == 13)
                {
                    CreateSuits("King", 10, ref deck);
                }
                else if (i == 12)
                {
                    CreateSuits("Queen", 10, ref deck);
                }
                else if (i == 11)
                {
                    CreateSuits("Jack", 10, ref deck);
                }
                else
                {
                    CreateSuits(i.ToString(), i, ref deck);
                }

            }

            return ShuffleDeck(ref deck);

        }

        public static Dictionary<string, int> ShuffleDeck(ref Dictionary<string, int> deck)
        {
            var rnd = new Random();
            //take current index value of dictionary items and change, if value has already been assigned, remove it from choices
            var shuffledDeck = new Dictionary<string, int>();

            for (var i = 0; i < 52; i++)
            {
                int checkindex = rnd.Next(52);
                var cardToAdd = deck.ElementAt(checkindex);

                if (!shuffledDeck.ContainsKey(cardToAdd.Key))
                {
                    shuffledDeck.Add(cardToAdd.Key, cardToAdd.Value);
                }
                else
                {
                    i--;
                }
            }
            return shuffledDeck;
        }
        //public static int CountedValue(this Dictionary<string, int> Hand, int score)
        //{
        //    int value = score;
        //    foreach (var card in Hand)
        //    {
        //        if (card.Key.Contains("Ace"))
        //        {
        //            if (value + 11 < 21)
        //            {
        //                value += 11;
        //            }
        //            else {
        //                value++;
        //            }
        //        }
        //        else
        //        {
        //            value += card.Value;
        //        }
        //    }
        //    return value;



    }
}

