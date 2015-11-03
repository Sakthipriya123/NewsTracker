using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NewsProject.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string FullArticle { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        //public ICollection<ApplicationUser> User { get; set; }

        public News()
        {
            this.Comments = new List<Comment>();
        }
    }
}