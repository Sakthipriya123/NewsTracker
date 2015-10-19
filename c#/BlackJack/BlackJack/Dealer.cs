using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer : Game
    {

        public void DealerChoice(Dictionary<string, int> PlayDeck, int currentCard)
        {
            if (PlayerScore < 17)
            {
                this.DealCards(PlayDeck, currentCard);
                Console.Write("The Dealer hits and receives a card");
                CardDealt = true;
            }
            else if (PlayerScore == 17 || PlayerHand.Keys.Contains("Ace"))
            {
                this.DealCards(PlayDeck, currentCard);
                Console.Write("The Dealer hits and receives a card");
                CardDealt = true;
            }
            else
            {
                Console.Write("The Dealer is staying.");
                CardDealt = false;
            }
        }

        public Dealer()
        {
            PlayerHand = new Dictionary<string, int>();
        }
    }

}
