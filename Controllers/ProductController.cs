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
            return View(products);
        }

        [HttpPost]

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(CreateProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    ID = _products.Count + 1,
                    Name = viewModel.Name,
                    Price = viewModel.Price,
                    Description = viewModel.Description
                };
                _products.Add(product);
            }
            return Redirect("Index");
        }
    }
}
