using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WaggyProject.Context;

namespace WaggyProject.ViewComponents.Default_Index
{
    public class DefaultProductsComponent: ViewComponent
    {
        private readonly WaggyContext _context;

        public DefaultProductsComponent(WaggyContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Categories.Include(x => x.Products).ToList();
            return View(values);
        }

    }
}
