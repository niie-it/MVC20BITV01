using Microsoft.AspNetCore.Mvc;
using MyEStore.Data;
using MyEStore.Models;

namespace MyEStore.Controllers
{
    public class AjaxController : Controller
    {
        private readonly MyeStoreContext _context;

        public AjaxController(MyeStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ServerTime()
        {
            return Content(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var data = _context.HangHoas
                .Where(hh => hh.TenHh.Contains(keyword))
                .Select(hh => new KetQuaTimKiemVM { 
                    MaHh = hh.MaHh,
                    TenHh = hh.TenHh,
                    DonGia = hh.DonGia.Value,
                    NgaySX = hh.NgaySx,
                    Loai = hh.MaLoaiNavigation.TenLoai
                }).ToList();

            return PartialView("TimKiemPartial", data);
        }
    }
}
