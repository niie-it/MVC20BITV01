using Microsoft.AspNetCore.Mvc;

namespace Buoi02_MVC.Controllers
{
    public class TestController : Controller
    {
        public string Hello(string name = "Thịnh")
        {
            return $"Hello {name}";
        }

        public int Random(int max = 100)
        {
            return new Random().Next(max);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult JsonDemo()
        {
            return Json(new { 
                Ten = "Tèp", Tuoi = 19
            });
        }
        public IActionResult ABC()
        {
            return Redirect("/Home/Privacy");
        }
        public IActionResult XYZ()
        {
            return RedirectToAction("Privacy", "Home");
        }
    }
}
