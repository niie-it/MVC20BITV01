using Microsoft.AspNetCore.Mvc;
using MyEStore.Data;
using MyEStore.Models;

namespace MyEStore.Controllers
{
	public class ThongKeController : Controller
	{
		private readonly MyeStoreContext _ctx;

		public ThongKeController(MyeStoreContext ctx)
		{
			_ctx = ctx;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Report()
		{
			var data = _ctx.ChiTietHds
				.GroupBy(cthd => new
				{
					cthd.MaHhNavigation.MaLoaiNavigation.TenLoai,
					cthd.MaHhNavigation.MaNccNavigation.TenCongTy
				})
				.Select(g => new Report
				{
					Category = g.Key.TenLoai,
					Supplier = g.Key.TenCongTy,
					Total = g.Sum(ct => ct.SoLuong * ct.DonGia),
					ItemCount = g.Sum(ct => ct.SoLuong),
					MaxPrice = g.Max(ct => ct.DonGia),
					MinPrice = g.Min(ct => ct.DonGia),
					Average = g.Average(ct => ct.DonGia),
				}).ToList();

			return View(data);
		}

		#region Thống kê Doanh thu theo Loại
		public IActionResult DoanhThuTheoLoai(DateTime fromDate, DateTime toDate)
		{
			var data = _ctx.ChiTietHds
				.Where(ct => ct.MaHdNavigation.NgayDat >= fromDate && ct.MaHdNavigation.NgayDat <= toDate)
				.GroupBy(cthd => cthd.MaHhNavigation.MaLoaiNavigation.TenLoai)
				.Select(g => new
				{
					Loai = g.Key,
					DoanhThu = g.Sum(ct => ct.SoLuong * ct.DonGia)
				}).ToList();

			return Json(data);
		}

		public IActionResult DoanhThu()
		{
			return View();
		}
		#endregion
	}
}
