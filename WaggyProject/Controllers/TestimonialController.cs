using Microsoft.AspNetCore.Mvc;
using WaggyProject.Context;
using WaggyProject.Entities;

namespace WaggyProject.Controllers
{
    //Primary Constructor
    public class TestimonialController(WaggyContext _context) : Controller
    {

        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        public IActionResult RemoveTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial model)
        {

            //Fast Fail Yöntemi 
            if (!ModelState.IsValid) //Kurallara uymuyorsa 
            {
                return View(model);
            }

            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
