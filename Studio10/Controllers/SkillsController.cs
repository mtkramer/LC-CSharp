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

        // /<controller>/form
        [HttpGet("form")]
        public IActionResult Form(string date = "", string cs = "", string js = "", string py = "")
        {
            string dt = DateTime.Now.ToString("yyyy'-'MM'-'dd");
            string html =
                "<h1>Update Learning Progress</h1>" +
                "<form method='post' action='/skills/update'>" +
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
                "</form>";
            return Content(html, "text/html");
        }

        // GET: /<controller>/update
        [HttpPost("update")]
        public IActionResult Update(string date, string cs, string js, string py)
        {
            return Content($"{UpdateLearning(date, cs, js, py)}", "text/html");
        }
        
        public static string UpdateLearning(string date, string cs, string js, string py)
        {
            return
                "<table style='border: 1px solid #333;'>" +
                    "<thead style='background-color: #999; color: #fff;'>" +
                        "<tr>" +
                            $"<th colspan='2'>Updated on {date}</th>" +
                        "</tr>" +
                    "</thead>" +
                    "<tbody>" +
                        "<tr>" +
                            $"<td style='border: 1px solid #333;'>C# learning progress: </td>" +
                            $"<td style='border: 1px solid #333;'>{cs}</td>" +
                        "</tr>" +
                        "<tr>" +
                            $"<td style='border: 1px solid #333;'>JavaScript learning progress: </td>" +
                            $"<td style='border: 1px solid #333;'>{js}</td>" +
                        "</tr>" +
                        "<tr>" +
                            $"<td style='border: 1px solid #333;'>Python learning progress: </td>" +
                            $"<td style='border: 1px solid #333;'>{py}</td>" +
                        "</tr>" +
                    "</tbody>" +
                "</table>";
        }

    }
}
/*
Add a new path to the site to display the information from the completed form.
*/