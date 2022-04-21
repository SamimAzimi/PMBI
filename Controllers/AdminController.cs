using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning.Models;

namespace learning.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Dashboard()
    {
        return View();
    }
    public IActionResult Allergense()
    {
        return View();
    }

    public IActionResult FoodEnergy()
    {
        return View();
    }
    public IActionResult ProductDetail()
    {
        return View();
    }
    public IActionResult ProductSetting()
    {
        return View();
    }
    public IActionResult RecipeSetting()
    {
        return View();
    }
    public IActionResult Settings()
    {
        return View();
    }
    public IActionResult SalesAnalyis()
    {
        return View();
    }

    public IActionResult Notification()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
