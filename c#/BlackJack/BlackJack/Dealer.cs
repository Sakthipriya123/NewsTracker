using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer
    {

        public Dictionary<string,int>  DealerHand { get; set; }
        public int DealerScore { get; set; } 

        public void DealCards(Dictionary<string, int> deck,int num)
        {
            var cardVal = num;

            var CardToDeal = deck.ElementAt(cardVal);
            this.DealerHand.Add(CardToDeal.Key, CardToDeal.Value);
            this.CountedValue();
            cardVal++;
        }
        public void DealerChoice(Dictionary<string, int> Playdeck,int currentCard)
        {
            if (DealerScore < 17)
            {
                this.DealCards(Playdeck, currentCard);
            }
            else if (DealerScore == 17 || DealerHand.Keys.Contains("Ace"))
            {
               this.DealCards(Playdeck,currentCard);
            }
            else
            {
                Console.Write("The Dealer is staying.");
            }
        }

        public void CountedValue()
        {
            this.DealerScore = 0;
            foreach (var card in DealerHand)
            {
                if (card.Key.Contains("Ace"))
                {
                    if (this.DealerScore + 11 < 21)
                    {
                        this.DealerScore += 11;
                    }
                    else
                    {
                        this.DealerScore++;
                    }
                }
                else
                {
                    this.DealerScore += card.Value;
                }
            }
        }
        public Dealer()
        {
            DealerHand = new Dictionary<string, int>();
        }
    }
}