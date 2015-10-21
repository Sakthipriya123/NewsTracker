using MovieFull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieFull.API
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Title="Star Wars", Director="Lucas" },
                new Movie {Id=2, Title="The Martian", Director="Scott" },
                new Movie {Id=3, Title="Ex Machina", Director="Garland" }
            };
        }

        public IHttpActionResult Post(Movie movie)
        {

            if (string.IsNullOrWhiteSpace(movie.title))
            {
                ModelState.AddModelErr
            }
            //add movie to the db
            return Created("movies/" + movie.id, movie);
        }
    }
}
