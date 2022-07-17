using Microsoft.EntityFrameworkCore;
using MovieTicketBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketBooking.Logics
{
    public class MovieLogic
    {
        public static List<Movie> GetComingSoonMovie()
        {
            using (var context = new MovieTicketBookingContext())
            {
                return context.Movies
                    .Include(x => x.GenreMovies)
                    .Where(x => x.StartDate >= System.DateTime.Today).ToList();
            }
        }
        public static List<GenreMovie> GetListGenreByMovieID(int MovieID)
        {
            using (var context = new MovieTicketBookingContext())
            {
                return context.GenreMovies.Where(x => x.MovieId == MovieID).ToList(); ;
            }
        }

        public static Movie GetMovieDetailByID(int Id)
        {
            using(var context = new MovieTicketBookingContext())
            {
                return context.Movies.Include(x => x.GenreMovies).Where(x=>x.MovieId==Id).FirstOrDefault();
            }
        }
        public static AgeLimit GetAgeLimit(int MovieID)
        {
            int ageLimitId=0;
            AgeLimit ageLimit = new AgeLimit();
            using (var context = new MovieTicketBookingContext())
            {
                ageLimitId = (int)context.Movies.FirstOrDefault(x => x.MovieId == MovieID).AgeLimit;
                return context.AgeLimits.FirstOrDefault(x=>x.AgeLimitId==ageLimitId);
            }
        }
    }
}
