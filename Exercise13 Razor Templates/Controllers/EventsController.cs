using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise13_Razor_Templates.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            Events.AddRange(new List<string>() { "String Loop", "Grace Hopper", "Code With Pride" });
            ViewBag.events = Events;

            return View();
        }
    }
}
