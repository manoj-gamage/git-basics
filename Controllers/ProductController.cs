using Microsoft.AspNetCore.Mvc;

namespace git_training.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Id = "SSN";
            ViewBag.Address = "9939";
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Name = "M1";
            return View();
        }
    }
}
