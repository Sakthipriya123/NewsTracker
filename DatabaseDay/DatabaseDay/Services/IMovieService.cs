using System.Collections.Generic;
using DatabaseDay.Models;

namespace DatabaseDay.Services
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        void EditMovie(Movie movie);
        IList<Movie> ListMovies();
        Movie GetMovie(int id);
    }
}