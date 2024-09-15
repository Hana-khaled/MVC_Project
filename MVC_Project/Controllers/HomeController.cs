using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        #region Session01
        //// using ActionResult
        //public ActionResult Index()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Hello from content result";

        //    return result;
        //}

        ////Using Helper Method
        //public ActionResult AboutUs()
        //{
        //    return Content("this is AboutUs Action");
        //} 
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
