using Exercise20_ORM_Relationships.Data;
using Exercise20_ORM_Relationships.Models;
using Exercise20_ORM_Relationships.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20_ORM_Relationships.Controllers
{
    public class EventsController : Controller
    {

        private EventDbContext context;
        public EventsController(EventDbContext dbContext) { context = dbContext; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // use .Include() to force ef eager loading
            List<Event> events = context.Events.Include(e => e.Category).ToList();

            return View(events);
        }

        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel(context.Categories.ToList());

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory category = context.Categories.Find(addEventViewModel.CategoryId);
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Category = category
                };

                context.Events.Add(newEvent);
                context.SaveChanges();

                return Redirect("/Events");
            }

            return View(addEventViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.events = context.Events.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                Event theEvent = context.Events.Find(eventId);
                context.Events.Remove(theEvent);
            }

            context.SaveChanges();

            return Redirect("/Events");
        }

        public IActionResult Detail(int id)
        {
            // .Include() cannot be chained with .Find() so .Single() is used instead
            Event evt = context.Events.Include(e => e.Category).Single(e => e.Id == id);
            EventDetailViewModel viewModel = new EventDetailViewModel(evt);

            return View(viewModel);
        }
    }
}
