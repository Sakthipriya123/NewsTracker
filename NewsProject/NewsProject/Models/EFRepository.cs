using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsProject.Models
{

    public class EFRepository :IEFRepository
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IList<News> ListNews()
        {
            return _db.News.ToList();
        }



        public void Insert(News news)
        {
            _db.News.Add(news);
            _db.SaveChanges();
        }
    }
}