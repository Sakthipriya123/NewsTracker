using CoderCamps;
using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NewsProject.Services
{
    public class CategoryServices :  ICategoryServices
    {
        private IGenericRepository _repo;

        public CategoryServices(IGenericRepository repo)
        {
            this._repo = repo;


        }
        [Authorize]
        public IList<CategoryView> ListCategories()
        {
            IList<CategoryView> category= _repo.Query<Category>().ToList().Select(c => new CategoryView { Id = c.Id, CategoryName = c.CategoryName}).ToList();
            return category;
        }

        public CategoryView GetNews(int id)
        {
            //ICollection<News> category = _repo.Query<News>().ToList();
            //return category;
            Category category = _repo.Find<Category>(id);
            var categoryview = new CategoryView
            {
                CategoryName = category.CategoryName,
                Id = category.Id,
                News = category.News.Select(c => new NewsView { Id = c.Id,Title = c.Title,Image = c.Image, Author = c.Author,Description=c.Description }).OrderByDescending(x => x.Id).ToList(),
             
            };
            return categoryview;
            
        }

       
    }
}