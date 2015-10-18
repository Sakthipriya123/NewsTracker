using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    { 
    public Dictionary<string, int> UserHand { get; set; }
    public int UserScore { get; set; }

    public void DealCards(Dictionary<string, int> deck, int num)
    {
        var cardVal = num;

        var CardToDeal = deck.ElementAt(cardVal);
        this.UserHand.Add(CardToDeal.Key, CardToDeal.Value);
        this.CountedValue();
            cardVal++;  
    }

    public void HitOrStay(Dictionary<string, int> PlayDeck,int num,int totalCardsValue)
    {
        Console.Write("The Dealer asks: Would you like another card? Yes or No (y or n) ");
        string choice = Console.ReadLine().ToLower();

             totalCardsValue = 0;
            if (choice == "y" || choice == "yes")
        {
            this.DealCards(PlayDeck, num);
                
             foreach(var cards in UserHand)
                {
                    totalCardsValue += cards.Value;
                }
         }
        else if(totalCardsValue >= 21)
        {
                CountedValue();
                //twentyOne = true;
        }


    }
        public void CountedValue()
        {
            this.UserScore = 0;
            foreach (var card in UserHand)
            {
                if (card.Key.Contains("Ace"))
                {
                    if (UserScore + 11 < 21)
                    {
                        UserScore += 11;
                    }
                    else
                    {
                        UserScore++;
                    }
                }
                else
                {
                    UserScore += card.Value;
                }
            }
        }

        public Player()
        {
            UserHand = new Dictionary<string, int>();
        }
    }


    //private static int CountedValue(Dictionary<string, int> Deck)
    //{
    //    int value=0;
    //    foreach (var entry in Deck)
    //    {               
    //        //if (entry.Key.Contains("Ace")) {

    //        //}
    //        value += entry.Value;                
    //    }
    //    return value;
    //}



}


