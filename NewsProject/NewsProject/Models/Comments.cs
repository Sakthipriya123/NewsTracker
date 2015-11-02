using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsProject.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}