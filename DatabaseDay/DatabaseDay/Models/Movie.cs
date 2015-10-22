using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseDay.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Title is Required!")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Director is Required!")]
        public string Director { get; set; }
    }
}