using Exercise14_Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Exercise14_Models.Controllers
{
    public class EventsController : Controller
    {

        static private List<Event> Events = new List<Event>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(new Event(name, description));

            return Redirect("/Events");
        }
    }
}
