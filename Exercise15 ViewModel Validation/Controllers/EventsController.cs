﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Exercise15_ViewModel_Validation.Models;
using Exercise15_ViewModel_Validation.Data;
using Exercise15_ViewModel_Validation.ViewModels;

namespace Exercise15_ViewModel_Validation.Controllers
{
    public class EventsController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Event> events = new List<Event>(EventData.GetAll());

            return View(events);
        }

        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            return View(addEventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {

            if (ModelState.IsValid)
            {
                EventData.Add(new Event(
                    addEventViewModel.Name,
                    addEventViewModel.Description,
                    addEventViewModel.ContactEmail,
                    addEventViewModel.Location,
                    addEventViewModel.NumberOfTickets
                ));
                return Redirect("/Events");
            }

            return View(addEventViewModel);

        }

        public IActionResult Delete()
        {
            //ViewBag.title = "Delete Events";
            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
    }
}
