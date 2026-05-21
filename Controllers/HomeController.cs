using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AttackTarget.Models;

namespace AttackTarget.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login2(string? username, string? password)
    {
        if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            ViewBag.ErrorMessage = "";
            return View("Login");
        }
        if (username == "admin" && password == "1234")
        {
            ViewBag.ErrorMessage = "Valid username or password.";
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid username or password.";
        }
        return View("Login");
    }
    [HttpGet]
    public IActionResult Login(string? username, string? password)
    {
        if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        {
            ViewBag.ErrorMessage = "";
            return View();
        }
        if (username == "admin" && password == "1234")
        {
            ViewBag.ErrorMessage = "Valid username or password.";
        }
        else
        {
            ViewBag.ErrorMessage = "Invalid username or password.";
        }
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
