using Lab07.Data;
using Lab07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Controllers
{
	public class ProductsController : Controller
	{
		private readonly MVC_NIIE_LabContext _context;

		public ProductsController(MVC_NIIE_LabContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var data = _context.Products
				.Include(p => p.Category)
				.Include(p => p.Supplier)
				.ToList();

			return View(data);
		}

		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.Suppliers = new SelectList(_context.Suppliers.ToList(), "Id", "Name");
			ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "NameVn");
			return View();
		}

		[HttpPost]
		public IActionResult Create(Product product, IFormFile ProductImage)
		{
			ViewBag.Suppliers = new SelectList(_context.Suppliers.ToList(), "Id", "Name");
			ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "NameVn");

			if (ProductImage != null)
			{
				product.Image = MyTool.UploadImageToFolder(ProductImage, "Products");
			}
			_context.Add(product);
			_context.SaveChanges();
			return RedirectToAction("Index");

		}
	}
}
