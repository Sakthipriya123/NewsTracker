using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using NewsProject.Services;

namespace NewsProject.API
{
    public class CategoriesController : ApiController
    {
        private ICategoryServices _categoryService;

        public CategoriesController(ICategoryServices categoryService)
        {
            this._categoryService = categoryService;

        }
        
        public IEnumerable<Category> Get()
        {
            //var news = _db.Categories.Include(c => c.News).Where(a => a.CategoryName.Equals("Sports"));
            return _categoryService.ListCategories();
        }

        [Authorize]
        public IHttpActionResult Get(int id)
        {
            var news = _categoryService.GetNews(id);
            if(news == null)
            {
                return NotFound();
            }
            return Ok(news);
        }
        
    }
}