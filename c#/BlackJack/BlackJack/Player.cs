using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player : Game
    {
        public void HitOrStay(Dictionary<string, int> PlayDeck, int num)
        {
            Console.Write("The Dealer asks: Would you like another card? Yes or No (y or n) ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "y" || choice == "yes")
            {
                DealCards(PlayDeck, num);
            }
            else
            {
                Console.Write("You decide to 'stay'");
                CardDealt = false;

            }


        }
        public Player()
        {
            PlayerHand = new Dictionary<string, int>();
        }





    }

}

