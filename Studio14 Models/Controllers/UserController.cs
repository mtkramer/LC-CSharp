using Microsoft.AspNetCore.Mvc;
using Studio14_Models.Models;

namespace Studio14_Models.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.verify = true;

            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitUserAddForm(User newUser, string verifyPassword)
        {
            if (newUser.Password != verifyPassword)
            {
                ViewBag.newUser = newUser;
                ViewBag.verify = false;
                return View("Add");
            }

            return Redirect("/spa");
        }
    }
}
