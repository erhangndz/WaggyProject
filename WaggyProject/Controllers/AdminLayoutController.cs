using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public PartialViewResult AdminLayoutNavbar()
        {
            return PartialView();
        }

        public PartialViewResult AdminLayoutSidebar()
        {
            return PartialView();
        }
    }
}
