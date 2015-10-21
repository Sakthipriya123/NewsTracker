using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullMovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Title should be required")]
        public string Title { get; set; }

        [MaxLength(10, ErrorMessage ="Should be no longer than 10")]
        [Required(ErrorMessage ="Enter the Director name")]
        public string Director { get; set; }
    }
}