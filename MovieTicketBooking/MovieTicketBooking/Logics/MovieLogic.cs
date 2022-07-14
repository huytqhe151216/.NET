using MovieTicketBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketBooking.Logics
{
    public class MovieLogic
    {
        public static List<Movie> GetComingSoonMovie()
        {
            using(var context = new MovieTicketBookingContext())
            {
                return context.Movies.Where(x=>x.StartDate>=System.DateTime.Today).ToList();
            }
        } 
    }
}
