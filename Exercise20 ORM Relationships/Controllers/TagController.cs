using Exercise20_ORM_Relationships.Data;
using Exercise20_ORM_Relationships.Models;
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
    }
}
