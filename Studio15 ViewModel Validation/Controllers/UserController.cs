using Microsoft.AspNetCore.Mvc;
using Studio15_ViewModel_Validation.Models;
using Studio15_ViewModel_Validation.ViewModels;

namespace Studio15_ViewModel_Validation.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    return View("Index", addUserViewModel);
                }

                ViewBag.error = "Passwords do not match. Please try again.";
                return View("Add", addUserViewModel);
            }

            return View("Add");
        }

    }
}
