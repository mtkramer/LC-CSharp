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
            ViewBag.DisplayVerify = false;
            return View();
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    return View("Index", addUserViewModel);
                }

                ViewBag.DisplayVerify = true;
                return View("Add", addUserViewModel);
            }

            ViewBag.DisplayVerify = true;
            return View("Add", addUserViewModel);
        }

    }
}
