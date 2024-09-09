using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        // using ActionResult
        public ActionResult Index()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello from content result";

            return result;
        }

        //Using Helper Method
        public ActionResult AboutUs()
        {
            return Content("this is AboutUs Action");
        }
    }
}
