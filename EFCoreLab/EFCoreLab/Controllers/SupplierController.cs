using EFCoreLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreLab.Controllers
{
	public class SupplierController : Controller
	{
		private readonly MVC_NIIE_LabContext _context;

		public SupplierController(MVC_NIIE_LabContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View(_context.Suppliers.ToList());
		}
	}
}
