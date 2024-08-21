using Microsoft.AspNetCore.Mvc;

namespace test

{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
