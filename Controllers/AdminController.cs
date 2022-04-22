using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning.Models;
using learning.Data;
namespace learning.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDBContext _db;

    public AdminController(ApplicationDBContext db)
    {
        _db = db;
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
        IEnumerable<UserModel> objUser = _db.users.ToList();
        return View(objUser);
    }
    public IActionResult SalesAnalyis()
    {
        return View();
    }

    public IActionResult Notification(MessageModel obj)
    {

        IEnumerable<MessageModel> objmessage = _db.messages.ToList();
        return View(objmessage);

    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
