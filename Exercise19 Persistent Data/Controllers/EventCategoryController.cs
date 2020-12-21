using Exercise19_Persistent_Data.Data;
using Microsoft.AspNetCore.Mvc;

namespace Exercise19_Persistent_Data.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;
        public EventCategoryController(EventDbContext dbContext) { context = dbContext; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
