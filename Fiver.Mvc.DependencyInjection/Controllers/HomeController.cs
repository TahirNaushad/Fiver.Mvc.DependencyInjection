using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
