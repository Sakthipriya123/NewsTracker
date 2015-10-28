using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction_Project.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public decimal BidAmount { get; set; }
        public decimal MinBid { get; set; }
        public decimal MaxBid { get; set; }
        [JsonIgnore]
        public Auction auction { get; set; }
       
    }
}