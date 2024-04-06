using JukohXIII_Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace JukohXIII_Website.Controllers
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
            string pathData = "Data/games.json";
            using var jsonFile = System.IO.File.OpenRead(pathData);
            var games = JsonSerializer.Deserialize<List<MyProjects>>(jsonFile);
            return View(games);
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