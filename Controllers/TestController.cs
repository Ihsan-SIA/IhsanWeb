using IhsanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class TestController : Controller
    {
       private readonly ILogger<TestController> _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
    }
}
