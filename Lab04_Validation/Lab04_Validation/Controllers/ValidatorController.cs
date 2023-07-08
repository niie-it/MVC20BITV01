using Microsoft.AspNetCore.Mvc;

namespace Lab04_Validation.Controllers
{
    public class ValidatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validate()
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dữ liệu hợp lệ";
                //TODO: Do business
            }
            else
            {
                ModelState.AddModelError("loi", "Còn lỗi");
            }
            return View("Index");
        }
    }
}
