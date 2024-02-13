using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using git_training.Models;

namespace git_training.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Name = "Lahiru Liyanage";
        ViewBag.Location = "Texas";
        ViewBag.State = "Texas";
        ViewBag.C1 = "C1";
        ViewBag.Name = "Lahiru Liyanage";
        ViewBag.Name = "Lahiru Liyanage";
        ViewBag.Name = "Lahiru Liyanage";
        ViewBag.Name = "Lahiru Liyanage";
        ViewBag.Name = "Manoj Gamage";
        ViewBag.Name = "M1";
        ViewBag.Name = "M2";
        ViewBag.Name = "RB1";
        ViewBag.Name = "RB2";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.Player = "Manoj Gamage";
        ViewBag.Player = "Manoj Gamage";
        ViewBag.Player = "Manoj Gamage";
        ViewBag.Player = "Manoj Gamage";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
