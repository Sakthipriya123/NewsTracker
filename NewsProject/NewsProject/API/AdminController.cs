﻿using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsProject.API
{
    public class AdminController : ApiController
    {


        private ApplicationDbContext _db = new ApplicationDbContext();

        [Authorize]
        public ICollection<ApplicationUser> Get()
        {
            var users = (from u in _db.Users select u).ToList();
            return users;
        }
        //// GET: api/Admin
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Admin/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Admin
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Admin/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Admin/5
        //public void Delete(int id)
        //{
        //}
    }
}
