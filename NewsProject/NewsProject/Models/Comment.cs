using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsProject.Models
{
    public class Comment
    {
        
        public int Id { get; set; }
        [Key]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public int NewsId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentedOn { get; set; }
       
    }
}