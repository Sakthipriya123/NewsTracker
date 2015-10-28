using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction_Project.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NumberOfBids { get; set; }
        public ICollection<Bid> Bids { get; set; }
        public string BidderName { get; internal set; }
    }
}