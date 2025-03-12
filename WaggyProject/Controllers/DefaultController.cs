using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
