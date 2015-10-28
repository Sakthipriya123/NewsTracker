using Auction_Project.Models;
using Auction_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Auction_Project.API
{
    public class AuctionController : ApiController
    {

        private IAuctionService _auctionService;

        public AuctionController(IAuctionService auctionService)
        {
            this._auctionService = auctionService;
        }
        
                
        
        // GET: api/Auction
        public IEnumerable<Auction> Get()
        {
            return _auctionService.ListAuction();
        }

        // GET: api/Auction/5
        public IHttpActionResult Get(int id)
        {
            var bid = _auctionService.GetItem(id);
            if(bid == null)
            {
                return NotFound();
            }
            return Ok(bid);
        }

        // POST: api/Auction
        public IHttpActionResult Post(Auction item)
        {
            if(item == null)
            {
                return BadRequest("Missing BidAuction");
            }

            if (item.Id == 0)
            {
                _auctionService.AddItem(item);
                return Created("/auction/" + item.Id, item);
            }
            else
            {
                _auctionService.EditItem(item);
                return Ok(item);
            }
        }
        

        // PUT: api/Auction/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Auction/5
        public void Delete(int id)
        {
        }
    }
}
