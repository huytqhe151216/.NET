using Microsoft.AspNetCore.Mvc;

namespace MovieTicketBooking.Controllers
{
    public class ListMovieController : Controller
    {
        public IActionResult NowShowing()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
    }
}
