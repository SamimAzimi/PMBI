using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning.Models;
using learning.Data;
namespace learning.Controllers;

public class HomeController : Controller
{

    private readonly ApplicationDBContext _db;

    public HomeController(ApplicationDBContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }



    public IActionResult Contact()
    {

        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Contact(MessageModel obj)
    {
        if (ModelState.IsValid)
        {
            _db.messages.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "your Message Has Been Sent Successfully";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
