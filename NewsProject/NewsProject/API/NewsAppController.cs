using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsProject.API
{
    public class NewsAppController : ApiController
    {


        private ApplicationDbContext _db = new ApplicationDbContext();
        
        public IEnumerable<News> Get()
        {
            return from n in _db.News select n;
        }
        
        // GET: api/NewsApp
        //public List<News> Get()
        //{
        //    return _news;
        //}

        //// GET: api/NewsApp/5
        public IHttpActionResult Get(int id)
        {
            var results = (from n in _db.News where n.Id == id select n).FirstOrDefault();
            if(results == null)
            {
                return NotFound();
            }
            return Ok(results);

        }

        //// POST: api/NewsApp
        //public void  Post(News value)
        //{

        //    //return;
        //}

        //// PUT: api/NewsApp/5
        //public IEnumerable<News> Put(int id, News value)
        //{
        //    return from n in _db.News where n.Id == id select n;
        //    //var news = _news.Find(m => m.Id == id);
        //    //news.Title = value.Title;
        //    //news.Image = value.Image;
        //    //news.Author = value.Author;
        //    //news.Description = value.Description;

        //    //return news.Title + news.Image + news.Author + news.Description;
        //}

        //// DELETE: api/NewsApp/5
        //public void Delete(int id)
        //{
        //}
    }
}
