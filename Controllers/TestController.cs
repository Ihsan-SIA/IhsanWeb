using IhsanWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IhsanWeb.Controllers
{
    public class TestController : Controller
    {
       
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
        public IActionResult TestBooking()
        {
            return View();
        }
    }
}
