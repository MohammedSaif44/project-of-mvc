using Microsoft.AspNetCore.Mvc;

namespace project_of_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("About Us");
        }
        public string AboutUs()
        {
            return "this is About Us";
        }
    }
}
