using Auction_Project.Models;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction_Project.Services
{
    public class AuctionService : IAuctionService
    {
        private IGenericRepository _repo;

        public AuctionService(IGenericRepository repo)
        {
            this._repo = repo;
        }

        public IList<Auction> ListAuction()
        {
            return _repo.Query<Auction>().ToList();
        }

        public Auction GetItem(int id)
        {
            return _repo.Find<Auction>(id);
        }

        public void AddItem(Auction auction)
        {
            _repo.Add(auction);
            _repo.SaveChanges();
        }
        public void EditItem(Auction auction)
        {
            var original = _repo.Find<Auction>(auction.Id);
            original.Name = auction.Name;
            original.Image = auction.Image;
            original.Description = auction.Description;
            original.NumberOfBids = auction.NumberOfBids;
            original.BidderName = auction.BidderName;
            _repo.SaveChanges();

        }
    }
}