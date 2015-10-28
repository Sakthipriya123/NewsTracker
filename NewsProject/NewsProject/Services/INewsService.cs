using NewsProject.Models;
using System.Collections.Generic;


namespace NewsProject.Services
{
    public interface INewsService
    {
        void AddNews(News news);
        News GetNews(int id);
        IList<News> ListNews();
    }
}