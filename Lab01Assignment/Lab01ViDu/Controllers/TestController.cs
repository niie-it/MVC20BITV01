using Microsoft.AspNetCore.Mvc;

namespace Lab01ViDu.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Demo()
        {
            ViewBag.HoTen = "Nguyễn Văn Tèo";
            ViewBag.NamSinh = 2002;
            ViewBag.GioiTinh = false;

            return View();
        }
    }
}
