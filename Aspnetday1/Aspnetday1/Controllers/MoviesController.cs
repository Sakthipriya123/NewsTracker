using Aspnetday1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspnetday1.Controllers
{
    public class MoviesController : Controller
    {

        private Repository _db = new Repository();


        // GET: Movies
        [Route("GetTheGoodMovies/Now")]
        public ActionResult Index()
        {
            var movies = _db.ListMovies();
            return View(movies);
        }

        [Route("Movies/Details/{id:int}")]

        public ActionResult Details(int id)
        {
            return Content("show details for movie" + id);
        }
    }
}