using BaiThiThucHanh.Data;
using BaiThiThucHanh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BaiThiThucHanh.Controllers
{
	public class KhachHangsController : Controller
	{
		private readonly QLBanHangContext _context;

		public KhachHangsController(QLBanHangContext context)
		{
			_context = context;
		}

		public IActionResult Create()
		{
			ViewBag.ThanhPho = new SelectList(_context.ThanhPhos.ToList(), "MaThanhPho", "TenThanhPho");

			return View();
		}

		[HttpPost]
		public IActionResult Create(KhachHang kh)
		{
			_context.Add(kh);
			_context.SaveChanges();
			return View();
		}


		[HttpGet("/donhang/{mahd}")]
		public IActionResult GetDonHang(int mahd)
		{
			ViewBag.MaHd = mahd;
			var hd = _context.HoaDons
				.Include(hd => hd.MaKhNavigation)
				.SingleOrDefault(p => p.MaHd == mahd);
			if (hd != null)
			{
				ViewBag.HoTenKH = hd.MaKhNavigation.TenCty;

				var data = _context.ChiTietHoaDons
				.Where(hd => hd.MaHd == mahd)
				.Select(cthd => new HoaDonVM
				{
					MaSp = cthd.MaSp,
					TenSp = cthd.MaSpNavigation.TenSp,
					DonGia = cthd.MaSpNavigation.DonGia.Value,
					SoLuong = cthd.SoLuong,
					DonViTinh = cthd.MaSpNavigation.DonViTinh
				});

				return View(data);
			}

			return NotFound();
		}
	}
}
