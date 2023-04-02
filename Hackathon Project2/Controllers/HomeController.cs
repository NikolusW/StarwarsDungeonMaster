using Hackathon_Project2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SharpTrooper.Core;
using Hackathon_Project2.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
//using AspNetCore;

namespace Hackathon_Project2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStarWarsApiService _starWarsApiService;

        public HomeController(ILogger<HomeController> logger, IStarWarsApiService starWarsApiService)
        {
            _logger = logger;
            _starWarsApiService = starWarsApiService;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();

            return View(model);
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