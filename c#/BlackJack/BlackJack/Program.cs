using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Program
    {
        public enum Win
        {
            Dealer, Player, None

        }

         public static  Win CheckWinner(Player user, Dealer dealer )
        {
            if (dealer.PlayerScore > 21 && user.PlayerScore < 22)
            {
                return Win.Player;
                
            }
            if (user.PlayerScore > 21 && dealer.PlayerScore < 22)
            {
                return Win.Dealer;

            }
            if(dealer.PlayerScore > user.PlayerScore)
            {
                return Win.Dealer;
            }        
            
            return Win.None;

          }


        static void Main(string[] args)
        {
            var playGame = true;

                        do
            {
                var Deck = new Dictionary<string, int>();

                Deck = Deck.CreateDeck();

                var dealer = new Dealer();

                var user = new Player();

                var gameOver = false;

                var cardBeingDealt = 0;
                //Deal the initial 2 cards to each player


                for (int i = 0; i < 2; i++)
                {
                    dealer.DealCards(Deck, cardBeingDealt);
                    if (dealer.CardDealt)
                    {
                        cardBeingDealt++;
                    }
                }

                for (int i = 2; i < 4; i++)
                {
                    user.DealCards(Deck, cardBeingDealt);
                    if (user.CardDealt)
                    {
                        cardBeingDealt++;
                    }
                }

                do
                {

                    user.ShowHand(user.PlayerHand);                                       
                    if (dealer.PlayerScore < 21 && user.PlayerScore < 21)
                    {
                        dealer.DealerChoice(Deck, cardBeingDealt);
                        if (dealer.CardDealt)
                        {
                            cardBeingDealt++;
                        }
                         user.HitOrStay(Deck, cardBeingDealt);
                            if (user.CardDealt)
                            {
                                cardBeingDealt++;
                            }
                        else
                        {
                            gameOver =true;
                        }
                      
                        
                    }
                    else
                    {
                        
                        Console.WriteLine("Your Score is {0}",user.PlayerScore);
                        Console.WriteLine("Dealer Score is {0}", dealer.PlayerScore);
                        CheckWinner(user, dealer);

                        //if(user.PlayerScore > dealer.PlayerScore)
                        //{
                        //    Console.WriteLine("Dealer Wins");
                        //}
                        // else if(user.PlayerScore > 21 || dealer.PlayerScore > 21)
                        //{
                        //    Console.WriteLine("Bust");
                        //}
                        //else if(dealer.PlayerScore > user.PlayerScore)
                        //{
                        //    Console.WriteLine("You Win");
                        //}
                        //Console.WriteLine("Game Over!");
                        gameOver = true;
                    }


                }
                while (!gameOver);




                playGame = false;
            }


            while (!playGame == false);







            //for (int i = 0; i < 52; i++)
            //{
            //    var newCard = Dealer.DealCards(Deck, i);
            //    Console.WriteLine(newCard);
            //}

            Console.ReadLine();

        }
    }
}

