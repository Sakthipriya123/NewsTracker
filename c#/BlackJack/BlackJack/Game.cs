using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    abstract class Game
    {

        public Dictionary<string, int> PlayerHand { get; set; }
        public int PlayerScore { get; set; }
        public bool CardDealt { get; set; }

        public void DealCards(Dictionary<string, int> deck, int num)
        {
            var CardToDeal = deck.ElementAt(num);
            this.PlayerHand.Add(CardToDeal.Key, CardToDeal.Value);
            this.CountedValue();
            CardDealt = true;
        }

        public void ShowHand(Dictionary<string, int> hand)
        {
            foreach (var card in hand)
            {
                Console.WriteLine(card.Key);
            }
            Console.WriteLine("Your total points are {0}", PlayerScore);
        }


        public void CountedValue()
        {
            this.PlayerScore = 0;
            foreach (var card in PlayerHand)
            {
                if (card.Key.Contains("Ace"))
                {
                    if (PlayerScore + 11 < 21)
                    {
                        PlayerScore += 11;
                    }
                    else
                    {
                        PlayerScore++;
                    }
                }
                else
                {
                    PlayerScore += card.Value;
                }
            }
        }

        public Game()
        {
            PlayerHand = new Dictionary<string, int>();
        }





    }

}


