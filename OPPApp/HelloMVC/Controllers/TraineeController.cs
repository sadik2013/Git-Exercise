using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class TraineeController : Controller
    {
        public IActionResult Entry(Trainee model)
        {
            if (ModelState.IsValid)
            {
                //database 
            }
            return View();
        }

    }
}