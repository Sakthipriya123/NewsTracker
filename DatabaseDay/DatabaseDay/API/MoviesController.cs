using DatabaseDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatabaseDay.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IEnumerable<Movie> Get()
        {
            return (from m in _db.Movies select m).ToList();
        }
    }
}
