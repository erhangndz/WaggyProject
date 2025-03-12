using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WaggyProject.Context;
using WaggyProject.Entities;

namespace WaggyProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly WaggyContext _context;

        public ProductController(WaggyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Eager Loading
            var values = _context.Products.Include(x => x.Category).ToList();
            return View(values);
        }

        public IActionResult AddProduct()
        {
            var categoryList = _context.Categories.ToList();
            ViewBag.categories = (from x in categoryList
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList(); 
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            var categoryList = _context.Categories.ToList();
            ViewBag.categories = (from x in categoryList
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();
            var value = _context.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
