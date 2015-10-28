using CoderCamps;
using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NewsProject.Services
{
    public class CategoryServices : ICategoryServices
    {
        private IGenericRepository _repo;

        public CategoryServices(IGenericRepository repo)
        {
            this._repo = repo;


        }
        [Authorize]
        public IList<Category> ListCategories()
        {
            IList<Category> category= _repo.Query<Category>().Include(c => c.News).ToList();
            return category;
        }

        public ICollection<News> GetNews(int id)
        {
            //ICollection<News> category = _repo.Query<News>().ToList();
            //return category;
            var categories = _repo.Query<News>().Include(c => c.Category).ToList();
            return categories;
            //var news = (from m in _repo.Query<Category>() where m.Id == 3 select m);
        }

       
    }
}