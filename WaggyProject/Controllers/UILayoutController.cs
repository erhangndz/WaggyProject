using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
