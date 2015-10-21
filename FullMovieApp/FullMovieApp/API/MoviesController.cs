using FullMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FullMovieApp.Controllers
{
    public class MoviesController : ApiController
    {


        private  static List<Movie> _movies = new List<Movie>     
            {
                new Movie {Id=1, Title="Star Wars", Director="Lucas" },
                new Movie {Id=2, Title="The Martian", Director="Scott" },
                new Movie {Id=3, Title="Ex Machina", Director="Garland" }
            };
        
        // GET: api/Movies
        public List<Movie> Get()
        {
            return _movies;

        }

        // GET: api/Movies/5
        public Movie Get(int id)
        {
            return _movies.Find(m => m.Id == id);
        }

        // POST: api/Movies

        public IHttpActionResult Post(Movie value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (value.Id == 0)
            {
                value.Id = _movies.Count() + 1;
                 _movies.Add(value);
                return Ok();
            }
            else
            {
                var movieToEdit = _movies.Find(m => m.Id == value.Id);
                movieToEdit.Title = value.Title;
                movieToEdit.Director = value.Director;
                return Ok();
            }

            
        }

        // PUT: api/Movies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movies/5
        public void Delete(int id)
        {
            //_movies.Remove(id);


        }
    }
}
