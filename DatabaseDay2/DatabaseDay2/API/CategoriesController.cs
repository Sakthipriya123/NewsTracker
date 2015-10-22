using DatabaseDay2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace DatabaseDay2.API
{
    public class CategoriesController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IList<Category> Get()
        {
            return _db.Categories.Include(c => c.Movies).ToList();
        }
    }
}
