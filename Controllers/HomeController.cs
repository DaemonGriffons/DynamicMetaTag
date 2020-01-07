using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynamicMetaTag.Models;

namespace DynamicMetaTag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Description"] = "Simply Adding the description meta tag";
            ViewData["Keywords"] = "dyamic meta tag, Meta tag, web development, dotnet core mvc";
            return View();
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
