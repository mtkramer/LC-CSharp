using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reading13_Razor_Templates.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.name = "Mike";
            ViewBag.Coffees = new List<string>();
            ViewBag.Coffees.AddRange(new List<string> { "French Roast", "Espresso", "Kopi Luwak", "Instant" });
            return View();
        }
        
        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
