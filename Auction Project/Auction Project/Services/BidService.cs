using Auction_Project.Models;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction_Project.Services
{
    public class BidService : IBidService
    {
        private IGenericRepository _repo;
        

        public BidService(IGenericRepository repo)
        {
            this._repo = repo;
        }

        public IList<Bid> ListBid()
        {
            return _repo.Query<Bid>().ToList();
        }

        public Bid GetItem(int id)
        {
            return _repo.Find<Bid>(id);
        }

        public void AddItem(Bid bid)
        {
            _repo.Add(bid);
        }
    }
}