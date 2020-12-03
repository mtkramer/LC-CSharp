using Exercise14_Models.Models;
using Microsoft.AspNetCore.Mvc;
using Exercise14_Models.Data;

namespace Exercise14_Models.Controllers
{
    public class EventsController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);

            return Redirect("/Events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        [Route("Events/Delete")]
        public IActionResult DeleteEvent(int[] eventIds)
        {
            foreach(int id in eventIds)
            {
                EventData.Remove(id);
            }

            return Redirect("/Events");
        }
    }
}
