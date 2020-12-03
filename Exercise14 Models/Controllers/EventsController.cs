﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise14_Models.Controllers
{
    public class EventsController : Controller
    {

        static private Dictionary<string, string> Events = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string name, string desc = "")
        {
            Events.Add(name, desc);


            return Redirect("/Events");
        }
    }
}
