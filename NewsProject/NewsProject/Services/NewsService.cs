﻿using CoderCamps;
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
            _repo.Add(news);
            _repo.SaveChanges();
        }

        public News GetNews(int id)
        {
            return _repo.Find<News>(id);
        }

        public IList<News> ListNews()
        {
            IList<News> news = _repo.Query<News>().ToList();
            return news;
        }
    }
}