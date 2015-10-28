using NewsProject.Models;
using NewsProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace NewsProject.API
{
    
    public class NewsAppController : ApiController
    {
        
        private INewsService _newsService;

        public NewsAppController(INewsService newsService)
        {
            this._newsService = newsService;
        }

        [Authorize]
        public IHttpActionResult Get()
        {

            var user = this.User as ClaimsPrincipal;
            if (!user.HasClaim("ViewNews", "true"))
            {
                return Unauthorized();
            }

            return Ok(this._newsService.ListNews());
        }
        
        // GET: api/NewsApp
        //public List<News> Get()
        //{
        //    return _news;
        //}

        //// GET: api/NewsApp/5
        public IHttpActionResult Get(int id)
        {
            var news = _newsService.GetNews(id);
            if(news == null)
            {
                return NotFound();
            }
            return Ok(news);

        }

        public IHttpActionResult Post(News news)
        {
            if(news == null)
            {
                return BadRequest("Missing news");
            }
            if(news.Id == 0)
            {
                _newsService.AddNews(news);
                return Created("/news/" + news.Id, news);
            }
            else
            {
                return Ok(news);
            }
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
