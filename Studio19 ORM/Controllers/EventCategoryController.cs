using Microsoft.AspNetCore.Mvc;
using Studio19_ORM.Data;
using Studio19_ORM.Models;
using Studio19_ORM.ViewModels;
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

        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();

            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Create(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory eventCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };
                context.EventCategories.Add(eventCategory);
                context.SaveChanges();

                return Redirect("/EventCategory");
            }

            return View(addEventCategoryViewModel);
        }
    }
}
