using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning.Models;

namespace learning.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Portflio()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Service()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(UserModel user)
    {
        // int UserId = user.UserId;
        // string name = person.Name;
        // string Password = person.Password;
        // string city = person.City;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
