using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise10_Controllers.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome/'>" +
                "<input type='text' name='name' />" +
                "<label for='lang'>Choose a Language:</label>" +
                "<select id='lang' name='lang'>" +
                "<option value='en'>--Please choose an option--</option>" +
                "<option value='ch'>Chinese</option>" +
                "<option value='fr'>French</option>" +
                "<option value='ge'>German</option>" +
                "<option value='sp'>Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }
        // GET: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World", string lang = "en")
        {
            return Content(CreateMessage(name, lang), "text/html");
        }

        public static string CreateMessage(string name, string lang)
        {
            string hello = "Hello";
            switch (lang)
            {
                case "ch":
                    hello = "Ni Hao"; break;
                case "fr":
                    hello = "Bonjour"; break;
                case "ge":
                    hello = "Hallo"; break;
                case "sp":
                    hello = "Hola"; break;
                default:
                    hello = "Hello"; break;

            }
            return $"<h1>{hello}, { name}!</h1>";
        }

    }
}
