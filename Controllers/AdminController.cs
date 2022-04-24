using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning.Models;
using learning.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Security.Principal;
using System.Security.Claims;
using System.Security.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace learning.Controllers;

public class AdminController : Controller
{
    private readonly ApplicationDBContext _db;

    public AdminController(ApplicationDBContext db)
    {
        _db = db;
    }
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
    [Authorize]
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

    [HttpGet("login")]
    public ActionResult Login(string ReturnUrl)
    {

        ViewData["ReturnUrl"] = ReturnUrl;
        // TempData["error"] =returnURL;
        return View();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserModel usr, string ReturnUrl)
    {
        var username = _db.users.SingleOrDefault(u => u.Name == usr.Name);
        var pass = _db.users.SingleOrDefault(u => u.Password == usr.Password);
        if (username != null & pass != null)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("username", "username"));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, "username"));
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimPrinciple = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(claimPrinciple);
            if (ReturnUrl != null)
            {
                string[] action = ReturnUrl.Split('/');
                return RedirectToAction(action[2]);
            }
            if (ReturnUrl == null)
            {

                return Redirect("/");
            }
            // TempData["error"] = returnURL;
            // return View();
        }
        ViewData["ReturnUrl"] = ReturnUrl;
        TempData["error"] = "Invalid User Name";
        return View();
    }

    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();
        return Redirect("/");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
