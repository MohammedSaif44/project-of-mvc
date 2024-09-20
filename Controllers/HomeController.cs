using Microsoft.AspNetCore.Mvc;

namespace project_of_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult  ContactUs()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }
    }
}
