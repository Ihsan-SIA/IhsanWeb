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

        public IActionResult Contact()
        {
            var contact = new ContactModel()
            {
                PhoneNumber = "+2348187357029", Email = "ihsan.ahmadsodeko@gmail.com"
            };
            return View(contact);
        }

        public IActionResult TestBooking()
        {
            return View();
        }
    }
}
