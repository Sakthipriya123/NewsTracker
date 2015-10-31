using CoderCamps;
using NewsProject.Models;
using NewsProject.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NewsProject.Services
{
    public class NewsService : INewsService
    {
        private IGenericRepository _repo;

        public NewsService(IGenericRepository repo)
        {
            this._repo = repo;
        }

        public void AddNews(News news)
        {
            //var category = _repo.Find<Category>(news.Category.Id);
            //category.News.Add(news);
            _repo.Add(news);
            _repo.SaveChanges();
        }

        public News GetNews(int id)
        {
            return this._repo.Find<News>(id);
                             
        }

        public IList<NewsListView> ListNews()
        {
           var  news = _repo.Query<News>().Include(c => c.Category).Select(n => new NewsListView {
                 Id = n.Id,
                 Title=n.Title,
                 Image = n.Image,                
                 Author = n.Author,
                 Description =n.Description,
               CategoryName = n.Category.CategoryName,

           }).ToList();
            return news;
        }
    }
}