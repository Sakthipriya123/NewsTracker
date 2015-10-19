using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aspnetday1.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie {Title="Star Wars", Director = "Lucas" },
                new Movie {Title="Ec Machina", Director = "Garland" },
                new Movie {Title="The Martian", Director = "Scott" }

            };
        }
    }
}