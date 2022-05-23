using Microsoft.AspNetCore.Mvc;

namespace ap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index(int id)
        {
            return Content(id.ToString());
            return View();
        }
        public ActionResult About(int id)
        {
            ViewBag.praduc = "cola";
            ViewData["Count"] = id;
            TempData["Type"] = "cola";
            return RedirectToAction("index");
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult FAQ(string name, string surname)
        {
            string Fullname = $"{name} {surname}";
            return Content(Fullname);
        }
    }
}
