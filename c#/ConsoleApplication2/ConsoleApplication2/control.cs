﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class control
    {
        public enum Suit
        {
            Heart,
            Diamond,
            Spade,
            Club
        }

        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

        public class Card
        {
            public Suit Suit { get; set; }
            public Face Face { get; set; }
            public int Value { get; set; }
        }

        public class Deck
        {
            private List<Card> cards;

            public Deck()
            {
                this.Initialize();
            }

            public void Initialize()
            {
                cards = new List<Card>();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j });

                        if (j <= 8)
                            cards[cards.Count - 1].Value = j + 1;
                        else
                            cards[cards.Count - 1].Value = 10;
                    }
                }
            }

            public void Shuffle()
            {
                Random rng = new Random();
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Card card = cards[k];
                    cards[k] = cards[n];
                    cards[n] = card;
                }
            }

            public Card DrawACard()
            {
                if (cards.Count <= 0)
                {
                    this.Initialize();
                    this.Shuffle();
                }

                Card cardToReturn = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                return cardToReturn;
            }

            public int GetAmountOfRemainingCrads()
            {
                return cards.Count;
            }

            public void PrintDeck()
            {
                int i = 1;
                foreach (Card card in cards)
                {
                    Console.WriteLine("Card {0}: {1} of {2}. Value: {3}", i, card.Face, card.Suit, card.Value);
                    i++;
                }
            }



        }

    }
}
