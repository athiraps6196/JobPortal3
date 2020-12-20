using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            JobDbContext job = new JobDbContext();
            var List = job.Candidates.ToList();
            return View(List);
        }

        public IActionResult Profile(int id)
        {
            int Id = id;
            JobDbContext job = new JobDbContext();
            var List = job.Candidates.Where(X => X.Id == Id).FirstOrDefault();
            return View(List);

        }
        [HttpGet]
        public IActionResult Search(String searchString)
        {
            JobDbContext job = new JobDbContext();
            var List = job.Candidates.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {

                var filterList =List.Where(x => x.Name. ToLower().Contains(searchString.ToLower())).ToList();

                return View(filterList);
            }
            else
            {


                return View(List);
            }


        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
