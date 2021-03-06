﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseDay2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        //public Category Category { get; set; }
    }
}