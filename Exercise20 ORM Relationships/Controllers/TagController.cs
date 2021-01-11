using Exercise20_ORM_Relationships.Data;
using Exercise20_ORM_Relationships.Models;
using Exercise20_ORM_Relationships.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20_ORM_Relationships.Controllers
{
    public class TagController : Controller
    {

        private EventDbContext context;
        public TagController(EventDbContext dbContext) { context = dbContext; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Tag> tags = context.Tags.ToList();

            return View(tags);
        }

        public IActionResult Add()
        {
            Tag tag = new Tag();

            return View(tag);
        }

        [HttpPost]
        public IActionResult Add(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Add(tag);
                context.SaveChanges();

                return Redirect("/Tag/");
            }

            return View("Add", tag);
        }

        public IActionResult AddEvent(int id)
        {
            Event evt = context.Events.Find(id);
            AddEventTagViewModel addEventTagViewModel = new AddEventTagViewModel(
                evt,
                context.Tags.ToList()
            );

            return View(addEventTagViewModel);
        }

        [HttpPost]
        public IActionResult AddEvent(AddEventTagViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                EventTag eventTag = new EventTag
                {
                    TagId = viewModel.TagId,
                    EventId = viewModel.EventId
                };

                context.EventTags.Add(eventTag);
                context.SaveChanges();

                return Redirect("/Events/Detail/" + viewModel.EventId);
            }

            return View(viewModel);
        }

    }
}
