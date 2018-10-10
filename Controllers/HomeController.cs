using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rockaway_App.Models;

namespace Rockaway_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        [HttpGet("rockaway")]
        public IActionResult About()
        {
            return View("Music");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
