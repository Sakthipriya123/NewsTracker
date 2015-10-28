using SecurityDay1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecurityDay1.API
{
    public class MoviesController : ApiController
    {
        [Authorize]
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Title="Star Wars", Director="Lucas" },
                new Movie {Id=2, Title="The Martian", Director="Scott" },
                new Movie {Id=3, Title="Ex Machina", Director="Garland" }
            };
        }
    }
}
