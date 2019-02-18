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
        public string Entry(Trainee model)
        {
            return "Name:" + model.Name + " " + "Reg No:" + model.RegNo;
        }

    }
}