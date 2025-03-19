using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.ViewComponents.Default_Index
{
    public class DefaultSendMessageComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
