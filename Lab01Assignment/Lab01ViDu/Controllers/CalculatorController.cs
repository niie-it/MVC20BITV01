using Microsoft.AspNetCore.Mvc;

namespace Lab01ViDu.Controllers
{
	public class CalculatorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Calculate(double SoHang01, double SoHang02, string PhepToan)
		{
			double ketQua = 0;
			switch (PhepToan)
			{
				case "+": ketQua = SoHang01 + SoHang02; break;
                case "-": ketQua = SoHang01 - SoHang02; break;
                case "*": ketQua = SoHang01 * SoHang02; break;
                case "/": ketQua = SoHang01 / SoHang02; break;
            }
			ViewBag.SoHang01 = SoHang01;
			ViewBag.SoHang02 = SoHang02;
			ViewBag.PhepToan = PhepToan;
			ViewBag.KetQua = ketQua;

			return View("Index");
		}

    }
}
