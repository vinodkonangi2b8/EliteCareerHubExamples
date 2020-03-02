using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EliteTravels.Models;
using Microsoft.AspNetCore.Mvc;

namespace EliteTravels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetMyPartialView()
        {
            return PartialView("_PartialViewExample");
        }

        public IActionResult QueryStringExmaple(int id, string name)
        {
            return Content($"Id is {id} and Name is {name}");
        }
    }
}
