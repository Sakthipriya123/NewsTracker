using Auction_Project.Models;
using Auction_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Auction_Project.API
{
    public class BidController
    {
        private IBidService _bidService;

        public BidController(IBidService bidService)
        {
            this._bidService = bidService;
        }

        public IEnumerable<Bid> Get()
        {
            return _bidService.ListBid();
         }
    }
}