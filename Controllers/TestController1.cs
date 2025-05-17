using IhsanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            var testItems = new List<TestItems>()
            {
                new() {Id = 1, TestName = "Testing mic", TestStatus = "Completed" },
                new() {Id = 2, TestName = "Testing camera", TestStatus = "Completed"},
                new() {Id = 3, TestName = "Testing screen", TestStatus = "Not completed"}
            };
            return View(testItems);
        }
    }
}
