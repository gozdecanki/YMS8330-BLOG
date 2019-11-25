using System;

using Blog.Data.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Send([FromBody] ContactSendDto contactSend)
        {
            return new JsonResult("ok");

        }
    }
}