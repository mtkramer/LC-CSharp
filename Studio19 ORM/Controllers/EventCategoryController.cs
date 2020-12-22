using Microsoft.AspNetCore.Mvc;
using Studio19_ORM.Data;
using Studio19_ORM.Models;
using System.Collections.Generic;
using System.Linq;

namespace Studio19_ORM.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;
        public EventCategoryController(EventDbContext dbContext) { context = dbContext; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<EventCategory> eventCategories = context.EventCategories.ToList();

            return View(eventCategories);
        }
    }
}
