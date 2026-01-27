namespace DemoMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string FullName)
        {
            ViewBag.thongBao = "Hello " + FullName;
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}