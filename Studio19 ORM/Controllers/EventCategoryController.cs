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
/*
Responds to GET requests at EventCategory/Create and returns a view called Create.cshtml.
Pass a new instance of AddEventCategoryViewModel to View()

Responds to POST requests at the route of your choosing.
Use error validation and ModelState.IsValid appropriately. If you want to review how to use ModelState.IsValid, check out the 
section on error validation.
Create a new instance of EventCategory and add it to the database if the form input meets the validation conditions.
Either reload the form or add a new event category to the database and direct the user back to the EventCategory/Index.cshtml template
*/