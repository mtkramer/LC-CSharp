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
            ViewBag.displayReverify = false;

            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitUserAddForm(User newUser, string verifyPassword)
        {
            ViewBag.newUser = newUser;

            if (newUser.Password != verifyPassword)
            {
                ViewBag.displayReverify = true;
                return View("Add");
            }

            return View("Index");
        }
    }
}
/*
Add a Date property in User, and initialize it to the time the user joined (i.e. when the User object was created).
At the bottom of User/Index.cshtml, add a div. Inside that element, add account details such as the user’s email and the date they joined.
*/