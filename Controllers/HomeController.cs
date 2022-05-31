using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using workshop1.Models;

namespace workshop1.Controllers
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
            IList<String> strList = new List<String>();
            strList.Add("Logic will get you from A to B. Imagination will take you everywhere.");
            strList.Add("There are 10 kinds of people. Those who know binary and those who don't.");
            strList.Add("There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.");
            strList.Add("It's not that I'm so smart, it's just that I stay with problems longer.");
            strList.Add("It is pitch dark. You are likely to be eaten by a grue.");
            Random rand = new Random();
            // Generate a random index less than the size of the array.  
            int idx = rand.Next(strList.Count);
            
            ViewData["Text"] = strList[idx];

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
