using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketBooking.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Detail(int id)
        {
            Movie movie = MovieLogic.GetMovieDetailByID(id); 
            AgeLimit ageLimit = MovieLogic.GetAgeLimit(id);
            ViewBag.AgeLimit = ageLimit;
            List<GenreMovie> genreMovie = MovieLogic.GetListGenreByMovieID(id);
            using (var context = new MovieTicketBookingContext())
            {
                ViewBag.ListGenres = context.Genres.ToList<Genre>();
            }
            
            return View(movie);
        }
    }
}
