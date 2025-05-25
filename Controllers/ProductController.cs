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
        
            var products = _productRepository.GetById(id);
            return View(products);
        }

        [HttpPut]
        public ActionResult Update(UpdateProductViewModel viewModel)
        {
            var products = _productRepository.GetByName(viewModel.Name);
            
            if (ModelState.IsValid)
            {
                _productRepository.Update(viewModel);
                return Redirect("Index");
            }
            return View(viewModel);
        }
    }
}
