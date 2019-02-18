using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVC.DatabaseContext;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class TraineeController : Controller
    {
      
        public IActionResult Entry()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Entry(Trainee model)
        {
            if (ModelState.IsValid)
            {
                TrainingDbContext db = new TrainingDbContext();
                db.Trainees.Add(model);
                db.SaveChanges();

            }
            return View();
        }

    }
}