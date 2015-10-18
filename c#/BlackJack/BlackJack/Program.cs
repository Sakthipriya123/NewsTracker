using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            var playGame = true;
            do {

                var Deck = new Dictionary<string, int>();

                Deck = Deck.CreateDeck();

                var dealer = new Dealer();

                var player = new Player();//Deal the initial 2 cards to each player

                var cardBeingDealt = 0;

                var gameOver = 21;

                for(int i = 0; i < 2; i++)
                {
                    dealer.DealCards(Deck, cardBeingDealt);
                    cardBeingDealt++;
                }

                for(int i =0; i < 2; i++)
                {
                    player.DealCards(Deck, cardBeingDealt);
                    cardBeingDealt++;
                }

                foreach(var cards in Deck)
                 {
                    Console.WriteLine(player.UserScore);
                    Console.WriteLine(player.UserHand);
                    dealer.DealerChoice(Deck, cardBeingDealt);
                    player.HitOrStay(Deck, cardBeingDealt, gameOver);

                }
                

                playGame = false;
            }

            while (playGame != false);



            //for (int i = 0; i < 3; i++)
            //{
            //    dealer.DealCards(Deck, i);
            //}


            //foreach (var cards in dealer.DealerHand)
            //{
            //    Console.WriteLine(cards.Key);
            //}
            //Console.WriteLine(dealer.DealerScore);

            //var newCard = Dealer.DealCards(Deck, 1);

            //dealer.DealerDeck.Add(newCard.Key.ToString(),newCard.Value);

            //Console.WriteLine(dealer.DealerDeck);



            //for (int i = 0;i < 52; i++)
            //{
            //    var newCard = Dealer.DealCards(Deck, i);
            //    Console.WriteLine(newCard);

            //}

            Console.ReadLine();

            }


        }

    }

