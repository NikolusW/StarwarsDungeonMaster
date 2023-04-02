using Hackathon_Project2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SharpTrooper.Core;


namespace Hackathon_Project2.Controllers
{
    public class SceneSelectionController : Controller
    {
        private readonly ILogger<SceneSelectionController> _logger;
        private readonly SharpTrooperCore _starWarsAPI;


        public SceneSelectionController(ILogger<SceneSelectionController> logger, SharpTrooperCore starWarsAPI)
        {
            _logger = logger;
            _starWarsAPI = starWarsAPI;
        }

        public IActionResult Index()
        {
           
            return View("Index");
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