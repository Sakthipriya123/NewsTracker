using System.Collections.Generic;
using NewsProject.Models;

namespace NewsProject.Services
{
    public interface INewsService
    {
        void AddNews(News news);
        News GetNews(int id);
        IList<NewsListView> ListNews();
    }
}