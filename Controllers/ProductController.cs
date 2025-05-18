using IhsanWeb.Models;
using IhsanWeb.Repository;
using IhsanWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var product = _productRepository.GetAll();
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateProductViewModel viewModel)
        {
            var product = _productRepository.GetByName(viewModel.Name);
            if (product is not null)
            {
                ViewBag.ErrorMessage = "Product already exists!";
                return View();
            }
            if (ModelState.IsValid)
            {
                _productRepository.Create(viewModel);
                return Redirect("Index");
            }
            return View();
        }
        public ActionResult Detail(int id)
        {
            var products = _productRepository.GetById(id);
            return View(products);
        }

        [HttpGet]
        public ActionResult Update(UpdateProductViewModel viewModel, string name)
        {
            var products = _productRepository.GetByName(name);
            if (products is null)
            {
                ViewBag.ErrorMessage = "Sorry product does not exist in records, try checking your spelling, or the product might just not be available.";
                return View();
            }
            if (ModelState.IsValid)
            {
                _productRepository.Update(viewModel, name);
                return Redirect("Index");
            }
            return View(viewModel);
        }
    }
}
