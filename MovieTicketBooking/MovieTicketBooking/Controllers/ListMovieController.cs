using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

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
            List<GenreMovie> genreMovies;
            foreach (Movie movie in listComingSoon)
            {
                genreMovies = MovieLogic.GetListGenreByMovieID(movie.MovieId);
                ViewData[movie.MovieId.ToString()] = genreMovies;
            }
            using (var context = new MovieTicketBookingContext())
            {
                ViewBag.ListGenres = context.Genres.ToList<Genre>();
            }

            return View(listComingSoon);
        }
        public IActionResult Favourite()
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                string json = HttpContext.Session.GetString("Account");
                Account account = JsonConvert.DeserializeObject<Account>(json);
                List<Movie> list = MovieLogic.GetListFavouriteMovieByCustomerId(account.AccountId);
                List<GenreMovie> genreMovies;
                foreach (Movie movie in list)
                {
                    genreMovies = MovieLogic.GetListGenreByMovieID(movie.MovieId);
                    ViewData[movie.MovieId.ToString()] = genreMovies;
                }
                using (var context = new MovieTicketBookingContext())
                {
                    ViewBag.ListGenres = context.Genres.ToList<Genre>();
                }
                return View(list);
            }

        }
    }
}
