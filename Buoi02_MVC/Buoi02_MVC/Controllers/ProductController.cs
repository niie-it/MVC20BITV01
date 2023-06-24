using Buoi02_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi02_MVC.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "IPhone 14 Pro Max 512GB",
                Price = 29999000,
                Quantity = 9,
                Image = "iphone14.jpg",
                Description = "IPhone 14 Pro Max 512GB Gold"
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod)
        {
            prod.Id = Guid.NewGuid();

            products.Add(prod);


            //chuyển về Action Index() để hiển thị
            // host/Product
            return RedirectToAction("Index");

            // host/Product/Create
            //return View("Index", products);
        }
    }
}
