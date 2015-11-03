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
            //News news = this._repo.Find<News>(id);
            News news = _repo.Query<News>().Include(r => r.Comments).Where(f => f.Id == id).ToList()[0];
            return news;
                             
        }

        public IList<NewsListView> ListNews()
        {
            var news = _repo.Query<News>().Include(c => c.Category).Include(r => r.Comments).Select(n => new NewsListView {
                Id = n.Id,
                Title = n.Title,
                Image = n.Image,
                Author = n.Author,
                Description = n.Description,
                CategoryName = n.Category.CategoryName,
                Comments = n.Comments,

           }).OrderByDescending(x => x.Id).ToList();
            return news;
        }
    }
}