using IhsanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<Product> _products = [];
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(_products);
        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
