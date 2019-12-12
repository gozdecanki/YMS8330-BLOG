

using Blog.Data.Context;
using Blog.Data.Dto;
using Blog.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
                Hit = 0,
                Deleted = false,
                CategoryId = blogAdd.CategoryId
            };

            _blogContext.Blogs.Add(blog);
            _blogContext.SaveChanges();
            return Ok(blog);
        }

        public IActionResult Detail(int id)//blogun id si
        {
            var blog = _blogContext.Blogs
                .Include(a=> a.User)
                .Include(a=> a.Comments)
                .SingleOrDefault(a=>a.Id==id);


            ViewData["Title"] = blog.Title;
            return View(blog);
        }

        public IActionResult AddComment([FromBody] BlogAddCommentDto blogAddComment)
        {

            Data.Models.Comment comment = new Data.Models.Comment
            {
                BlogId=blogAddComment.BlogId,
                CreateDate=DateTime.UtcNow,
                Content=blogAddComment.Comment,
                Deleted=false,
                Email=blogAddComment.Email,
                Nickname=blogAddComment.Nickname,
                ParentCommentId=blogAddComment.ParentCommentId,
                VoteUp=0,
                DownUp=0
            };

            _blogContext.Comments.Add(comment);
            _blogContext.SaveChanges();
            return new JsonResult("ok");
        }


    }
}