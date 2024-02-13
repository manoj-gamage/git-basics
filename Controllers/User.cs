using Microsoft.AspNetCore.Mvc;

namespace git_training.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Name = "Manoj Gamage";
            return View();
        }
    }
}
