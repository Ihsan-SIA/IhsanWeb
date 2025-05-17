using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IhsanWeb.Models;

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
        var products = new List<Product>()
        {
            new() {ID = 1, Name = "James", Age = 10},
            new() {ID = 2, Name = "Jessica", Age = 15},
            new() {ID = 3, Name = "Kakanga", Age = 22},
            new() {ID = 4, Name = "Kulusevski", Age = 33}
        };
        return View(products);
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
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
