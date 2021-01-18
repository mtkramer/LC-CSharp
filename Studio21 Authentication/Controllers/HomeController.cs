using Microsoft.AspNetCore.Mvc;
using Studio21_Authentication.Data;
using Studio21_Authentication.Models;
using Studio21_Authentication.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Studio21_Authentication.Controllers
{
    public class HomeController : Controller
    {
        private JobDbContext context;

        public HomeController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Job> jobs = context.Jobs.ToList();

            return View(jobs);
        }

        [HttpGet("/Add")]
        public IActionResult Add()
        {
            AddJobViewModel addJobViewModel = new AddJobViewModel();

            return View(addJobViewModel);
        }


        public IActionResult ProcessAddJobForm(AddJobViewModel addJobViewModel)
        {
            if (ModelState.IsValid)
            {
                Job newJob = new Job
                {
                    Name = addJobViewModel.Name,
                    Employer = addJobViewModel.Employer,
                    Skill = addJobViewModel.Skill
                };

                context.Jobs.Add(newJob);
                context.SaveChanges();

                return Redirect("Index");
            }

            return View("Add", addJobViewModel);
        }
    }

}
