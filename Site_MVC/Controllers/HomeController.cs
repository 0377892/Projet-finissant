using Microsoft.AspNetCore.Mvc;

namespace Site_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
