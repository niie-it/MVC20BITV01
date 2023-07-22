using Lab04_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab04_Validation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult CheckExistedEmployeeNo(string EmployeeNo)
        {
            var employees = new string[] { "111", "777", "666" };
            if (employees.Contains(EmployeeNo))
            {
                return Json(data: "Mã này đã có");
            }
            return Json(data: true);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {
                //hợp lệ
            }
            else
            {
                ModelState.AddModelError("loi", "Còn lỗi!");
            }
            return View();
        }
    }
}
