using Microsoft.AspNetCore.Mvc;

namespace LifeTimeExampleWithDependencyInjection.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            HttpContext.Session.SetInt32("Rollno", 737);
            HttpContext.Session.SetString("StudentName", "Shrushti");
            //ViewBag.Rollno = HttpContext.Session.GetInt32("Rollno");
            //ViewBag.Sname = HttpContext.Session.GetString("StudentName");

        return RedirectToAction("ShowValues");
        }
        public ActionResult ShowValues()
        {
            ViewBag.Rollno = HttpContext.Session.GetInt32("Rollno");
            ViewBag.Sname = HttpContext.Session.GetString("StudentName");

            return View();
        }

        public ActionResult SomeAction()
        {
            ViewBag.value1 = "Hello";
            return View();
        }

        public ActionResult Greetings()
        {
            ViewBag.value1 = "Good Day";
            return View();
        }
    }
}
