using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ForAddAsync(Candidates candidates)
        {
            if (candidates.FileToUpload == null || candidates.FileToUpload.Length == 0)
                return Content("file not selected");
            //string path = (@"C:\Users\nithe\Source\Repos\KD-Company\KD Company\wwwroot\Car\");
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/Image",
                       candidates.FileToUpload.FileName);
            Console.WriteLine(path);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await candidates.FileToUpload.CopyToAsync(stream);
            }
            using (JobDbContext dbContext = new JobDbContext())
            {
                candidates.FileName = candidates.FileToUpload.FileName;
                dbContext.Candidates.Add(candidates);

                //dbContext.AddBooks.Add(addbook.SelectedStatus=="0").;
                /// dbContext.addbook.SelectedStatus == "0";
                dbContext.SaveChanges();

            }

            return RedirectToAction("Add");

        }
        public IActionResult ViewCandidates()
        {
            JobDbContext job = new JobDbContext();
            var CanditatesList= job.Candidates.ToList();
            return View(CanditatesList);

           


        }
    }
}
