

using Blog.Data.Context;
using Blog.Data.Dto;
using Blog.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using System.Collections.Generic;
using System;
using System.Linq;

namespace Blog.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _blogContext;
        public BlogController( BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult New()
        {
          List<Category> categories = _blogContext.Categories.Where(a=> !a.Deleted).ToList();
            return View(categories);
        }

        public IActionResult Add([FromBody] BlogAddDto blogAdd)
        {
            int userId = HttpContext.Session.GetInt32("UserId").Value;
            Blog.Data.Models.Blog blog = new Blog.Data.Models.Blog()
            {
                UserId = userId,
                Title = blogAdd.Title,
                Content = blogAdd.Content,
                CreateDate = DateTime.UtcNow,
                Hit=0,
                Deleted=false,
                CategoryId=1
            };

            _blogContext.Blogs.Add(blog);
            return Ok();
        }


    }
}