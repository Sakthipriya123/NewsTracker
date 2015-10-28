using System.Collections.Generic;
using Auction_Project.Models;

namespace Auction_Project.Services
{
    public interface IBidService
    {
        void AddItem(Bid bid);
        Bid GetItem(int id);
        IList<Bid> ListBid();
    }
}