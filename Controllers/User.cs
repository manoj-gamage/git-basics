using Microsoft.AspNetCore.Mvc;

namespace git_training.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
