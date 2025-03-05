using Microsoft.AspNetCore.Mvc;
using WaggyProject.Context;
using WaggyProject.Entities;

namespace WaggyProject.Controllers
{
    public class CategoryController : Controller
    {

        private readonly WaggyContext _context;

        public CategoryController(WaggyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var value = _context.Categories.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult UpdateCategory(int id)
        {
            var value = _context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
