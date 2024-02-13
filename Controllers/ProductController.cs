using Microsoft.AspNetCore.Mvc;

namespace git_training.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Manoj Gamage";
            ViewBag.Id = "SSN";
            return View();
        }
    }
}
