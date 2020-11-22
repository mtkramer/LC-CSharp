using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio10.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = 
                "<h1>Skills Tracker</h1>" +
                "<h2>Languages</h2>" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet("form")]
        [HttpPost("form")]
        // /<controller>/form
        public IActionResult Form(string date = "", string cs = "", string js = "", string py = "")
        {
            string dt = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            string html = 
                "<h1>Update Learning Progress</h1>" +
                "<form>" +
                    "<div>" +
                        "<label for='date'>Today's Date:</label>" +
                        $"<input id='date' type='date' name='date' value='{dt}'></input>" +
                    "</div>" +
                    "<div>" +
                        "<label for='cs'>C# progress</label>" +
                        "<select id='cs' name='cs' required>" +
                            "<option value=''>--Please select one--</option>" +
                            "<option value='none'>Haven't started yet</option>" +
                            "<option value='beginning'>Beginning</option>" +
                            "<option value='fluent'>Fluent</option>" +
                            "<option value='expert'>Expert level</option>" +
                        "</select>" +
                    "</div>" +
                    "<div>" +
                        "<label for='js'>JavaScript progress</label>" +
                        "<select id='js' name='js' required>" +
                            "<option value=''>--Please select one--</option>" +
                            "<option value='none'>Haven't started yet</option>" +
                            "<option value='beginning'>Beginning</option>" +
                            "<option value='fluent'>Fluent</option>" +
                            "<option value='expert'>Expert level</option>" +
                        "</select>" +
                    "</div>" +
                    "<div>" +
                        "<label for='py'>Python progress</label>" +
                        "<select id='py' name='py' required>" +
                            "<option value=''>--Please select one--</option>" +
                            "<option value='none'>Haven't started yet</option>" +
                            "<option value='beginning'>Beginning</option>" +
                            "<option value='fluent'>Fluent</option>" +
                            "<option value='expert'>Expert level</option>" +
                        "</select>" +
                    "</div>" +
                    "<div>" +
                        "<input type='submit' value='Update Progress'></input>" +
                    "</div>" +
                "</form>" +
                $"{Update(date, cs, js, py)}";
            return Content(html, "text/html");
        }

        public static string Update(string date = "", string cs = "", string js = "", string py = "")
        {
            if (date.Equals("")) { return ""; }
            else
            {
                return
                    $"<h1>Updated on {date}</h1>" +
                    $"<p>C# learning progress: {cs}</p>" +
                    $"<p>JavaScript learning progress: {js}</p>" +
                    $"<p>Python learning progress: {py}</p>";
            }
        }

    }
}
