using AzureApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AzureApi.API
{
    public class AnimalController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        public IHttpActionResult Get()
        {
            return Ok(_db.Animal.ToList());
        }
    }
}
