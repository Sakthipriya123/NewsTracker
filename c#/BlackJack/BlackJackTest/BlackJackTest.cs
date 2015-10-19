using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;
using System.Collections.Generic;

namespace BlackJackTest
{
    [TestClass]
    public class BlackJackTest
    {
       
        [TestMethod]
        public void CheckDealerWins()//check if 'face
        {
            //Arrange
            var playerHand = new Dictionary<string, int>();
            playerHand.Add("10", 1);
            playerHand.Add("5", 2);

            var dealerHand = new Dictionary<string, int>();
            dealerHand.Add("10", 1);
            dealerHand.Add("11", 5);

            var player = new Player();
            var dealer = new Dealer();

            player.PlayerHand = playerHand;
            dealer.PlayerHand = dealerHand;
            //Act

            player.CountedValue();
            dealer.CountedValue();

            var results = Program.CheckWinner(player, dealer);


            //Assert

            Assert.AreEqual(Program.Win.Dealer, results);

        }
        //[TestMethod]
        //public void IsItRandom()//chec
        //{
        //}
        //[TestMethod]
        //public void IsAceAssigned()//If card is an ace, logic should give ace an automatic value
        //{
        //}
    }
}
