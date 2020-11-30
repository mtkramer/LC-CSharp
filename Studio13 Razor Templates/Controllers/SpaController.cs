using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class SpaController : Controller
    {
        public bool CheckSkinType(string skinType, string facialType)
        {

            if (facialType != "Microdermabrasion")
            {
                if (skinType == "oily" && facialType != "Rejuvenating")
                {
                    return false;
                }
                else if (skinType == "combination" && (facialType != "Rejuvenating" || facialType != "Enzyme Peel"))
                {
                    return false;
                }
                else if (skinType == "dry" && facialType != "Hydrofacial")
                {
                    return false;
                }
            }

            return true;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string name, string skinType, string maniPedi)
        {
            List<string> facials = new List<string>()
            {
                "Microdermabrasion", "Hydrofacial", "Rejuvenating", "Enzyme Peel"
            };

            List<string> appropriateFacials = new List<string>();
            for (int i = 0; i < facials.Count; i++)
            {
                if (CheckSkinType(skinType, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }
            
            ViewBag.name = name;
            ViewBag.skinType = skinType;
            ViewBag.appropriateFacials = appropriateFacials;
            ViewBag.maniPedi = maniPedi;

            return View();
        }


    }
}
/*
2. Modify the form to allow the user to select either a manicure or pedicure or both. If the user selects both, display both 
the manicure and pedicure descriptions in the Menu view.
3. Work with routes and paths to display the spa menu page on a separate route from the form
*/