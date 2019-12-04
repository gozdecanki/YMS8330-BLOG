﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Data.Dto
{
   public class ManageNewBlogActionDto
    {    [Required]
        public int CategoryId { get; set; }
        [Required,MinLength(2),MaxLength(150)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }


      
    }
}
