using IhsanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Product> _products = [];
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new() {Name = "Redmi 12C", Description = "An android phone of the redmi brand", ID = 1, Price = 50_000 },
                new() {ID = 2, Name = "iPhone 13", Description = "Major android competitor", Price = 100_000}
            };
            _products.AddRange(products);
            return View(products);
        }

        [HttpPost]
        public ActionResult Create(CreateProductViewModel createViewModel)
        {
            return View();
        }
    }
}
