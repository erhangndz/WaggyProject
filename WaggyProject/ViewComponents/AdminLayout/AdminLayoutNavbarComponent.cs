using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WaggyProject.Entities;

namespace WaggyProject.ViewComponents.AdminLayout
{
    public class AdminLayoutNavbarComponent: ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public AdminLayoutNavbarComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           var userName =  User.Identity.Name;

            var user = await _userManager.FindByNameAsync(userName);

            ViewBag.fullName = String.Join(" ", user.FirstName, user.LastName);
            ViewBag.userName = userName;
            return View();
        }
    }
}
