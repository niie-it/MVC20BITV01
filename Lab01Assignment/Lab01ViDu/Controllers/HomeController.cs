using Lab01ViDu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab01ViDu.Controllers
{
    public class HomeController : Controller
    {
        public string Hello(string name = "Tèo")
        {
            return $"Hello Mr/Ms {name}";
        }

        public int LuckyNumber()
        {
            return new Random().Next(100, 1000);
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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