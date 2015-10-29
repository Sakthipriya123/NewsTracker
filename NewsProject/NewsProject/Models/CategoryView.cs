using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsProject.Models
{
    public class CategoryView
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<NewsView> News { get; set; }
    }
}