using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise10_Controllers.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Hello, World!</h1>";
            return Content(html, "text/html");
        }
        // GET: /<controller>/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content($"<h1>Welcome to my app, {name}!</h1>", "text/html");
        }

    }
}
