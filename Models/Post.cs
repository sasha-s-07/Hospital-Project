﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace team2Geraldton.Models
{
    public class Post
    {
        
        public int PostId { get; set; }
        
        public string Title { get; set; }
       
        public string Type { get; set; }
        [AllowHtml]
        
        public string Description { get; set; }

    }
    public class PostDto
    {
      
        public int PostId { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Job Type")]
        public string Type { get; set; }
        [Required]
        [DisplayName("Job Description")]
        public string Description { get; set; }
        

    }
}
