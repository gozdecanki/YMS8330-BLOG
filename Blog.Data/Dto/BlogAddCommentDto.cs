using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data.Dto
{
  public  class BlogAddCommentDto
    {

        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        public int BlogId { get; set; }
        public int? ParentCommentId { get; set; }
    }
}
