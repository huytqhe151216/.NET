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
        public static void InsertFavouriteMovie(int cid, int mid)
        {
            var context = new MovieTicketBookingContext();
            FavouriteList favourite =new FavouriteList()
            {
                CustomerId = cid,
                MovieId = mid,
            };
            context.FavouriteLists.Add(favourite);
            context.SaveChanges();
        }
        public static bool CheckLoveMovieByCustomer(int cid, int mid)
        {
            var context = new MovieTicketBookingContext();
            FavouriteList favourite=context.FavouriteLists.FirstOrDefault(x => x.MovieId == mid && x.CustomerId == cid);
            if (favourite==null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public static void DeleteFavouriteMovie(int cid, int mid)
        {
            var context = new MovieTicketBookingContext();
            FavouriteList favourite = context.FavouriteLists.FirstOrDefault(x => x.MovieId == mid && x.CustomerId == cid);
            context.Remove(favourite);
            context.SaveChanges(true);
        }
        public static List<Movie> GetListFavouriteMovieByCustomerId(int id)
        {
            var context = new MovieTicketBookingContext();
            List<FavouriteList> favourite =context.FavouriteLists.Where(x => x.CustomerId == id).ToList();
            List<Movie> list = new List<Movie>();
            foreach (FavouriteList f in favourite)
            {
                Movie movie = context.Movies.Include(x=>x.GenreMovies).FirstOrDefault(x => x.MovieId == f.MovieId);
                list.Add(movie);
            }
            return list;
        }
    }
}
