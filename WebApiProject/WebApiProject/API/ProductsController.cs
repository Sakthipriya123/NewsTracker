using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;

namespace WebApiProject.API
{
    public class ProductsController : ApiController
    {
        private List<Product> _products = new List<Product>
        {
            new Product {Id=1, Name="Bread", Price=2.33m },
            new Product {Id=2, Name="Tesla", Price=120000m },
            new Product {Id=3, Name="Apples", Price=1.22m }
        };

        public IEnumerable<Product> Get()
        {
            return _products;
        }

        //checking if multiple get methods works ==yes its works for( overload)

        public IHttpActionResult Get(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product); 

        }

        //the browser will call only Get() or post() or .... not any another methos with some name or any
        //if i want to use the fred method use httpget

        [HttpGet]
        public string Fred()
        {
            return "Hi";
        }
    }
}
