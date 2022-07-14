using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using System.Collections.Generic;

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
            List<Movie> listComingSoon = MovieLogic.GetComingSoonMovie();

            return View(listComingSoon);
        }
    }
}
