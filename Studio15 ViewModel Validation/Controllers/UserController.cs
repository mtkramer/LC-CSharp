using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                return View("Index", addUserViewModel);
            }

            return View("Add", addUserViewModel);
        }

    }
}
