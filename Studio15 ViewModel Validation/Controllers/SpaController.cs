using Microsoft.AspNetCore.Mvc;
using Studio15_ViewModel_Validation.Models;

namespace Studio15_ViewModel_Validation.Controllers
{
    public class SpaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string skintype, string manipedi)
        {
            Client newClient = new Client(skintype, manipedi);
            newClient.SetFacials(newClient.SkinType);
            ViewBag.client = newClient;
            return View();
        }
    }
}
