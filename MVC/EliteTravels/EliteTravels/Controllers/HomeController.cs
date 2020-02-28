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

        [HttpPost]
        public void BookingSubmit([Bind("From,To,TravelDate,ReturnDate")]Booking booking)
        {

        }
    }
}
