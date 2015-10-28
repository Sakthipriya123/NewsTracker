namespace Auction_Project.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Auction_Project.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Auction_Project.Models.ApplicationDbContext context)
        {
            var auctions = new Auction[]
            {
               new Auction
               {
                   Name = "ROUSSEAU SUTER MENS WATCH",
                   Image = "http://static.ubid.com/mgen/vximg/scale.ms?args=%22http://www.myatmarket.com/pics/62623/62623521.jpg%22,275,275",
                   Description = "Manufacturer - Rousseau",
                   NumberOfBids = 6,
                   BidderName ="Don",
                   Bids = new Bid[]

                   {
                       new Bid {BidAmount=20 }
                   }

               },
               new Auction
               {
                   Name = "Bernoulli Chimera 3 Time Zone Mens Watch",
                   Image = "http://static.ubid.com/mgen/vximg/scale.ms?args=%22http://www.myatmarket.com/pics/62622/62622160f.jpg%22,275,275",
                   Description = "Manufacturer - Bernoulli",
                   NumberOfBids = 6,
                   BidderName ="sam",
                    Bids = new Bid[]
                   {
                       new Bid {BidAmount=40 }
                   }
                  }

            };

           

            //var bids = new Bid[]
            //{
            //   new Bid
            //   {
            //       BidAmount = 20,
            //       MinBid = 5,
            //       MaxBid = 20,
            //       auction = new Auction[]
            //       {
            //          new Auction {BidderName="Don",Name ="ROUSSEAU SUTER MENS WATCH" },
            //          new Auction {BidderName="Mac" ,Name ="Bernoulli Chimera 3 Time Zone Mens Watch"}
            //       }
            //   }
            //};
            context.Auctions.AddOrUpdate(a => a.Id, auctions);
            //context.Bids.AddOrUpdate(b => b.Id, bids);

        }
    }
}
