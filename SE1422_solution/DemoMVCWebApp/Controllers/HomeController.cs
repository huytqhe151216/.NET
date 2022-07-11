using Microsoft.AspNetCore.Mvc;

namespace DemoMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public void DoSomething()
        {

        }
        public string List()
        {
            return "Action list";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
