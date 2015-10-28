using System.Collections.Generic;
using Auction_Project.Models;

namespace Auction_Project.Services
{
    public interface IAuctionService
    {
        void AddItem(Auction bid);
        Auction GetItem(int id);
        void EditItem(Auction bid);
        IList<Auction> ListAuction();
    }
}