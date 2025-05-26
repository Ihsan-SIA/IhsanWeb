using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IhsanWeb.Models;
using IhsanWeb.ViewModel;

namespace IhsanWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var products = new Product()
        {
            ID = 5, Name = "Android", Age =200_000, Description = "This is a top competitor with IOS"
        };
        return View(products);
    }
    
    public IActionResult About()
    {
        var product = new Product()
        {
            ID = 23,
            Name = "Redmi",
            Price = 50_000,
            Description = "Xiaomi product"
        };
        return View(product);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Test()
    {
        var testItems = new List<TestItemsModel>()
            {
                new() {Id = 1, TestName = "Testing phone mic", TestStatus= "Completed" },
                new() {Id = 2, TestName = "Testing phone camera", TestStatus= "Completed"},
                new() {Id = 3, TestName = "Testing phone screen", TestStatus = "Not completed"}
            };
        return View(testItems);
    }

    public IActionResult Contact()
    {
        var contact = new ContactModel()
        {
            PhoneNumber = "+2348187357029",
            Email = "ihsan.ahmadsodeko@gmail.com"
        };

        return View(contact);
    }

    public IActionResult TestBooking()
    {
        return View();
    }
}
