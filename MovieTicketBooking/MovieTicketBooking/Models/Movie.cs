using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Movie
    {
        public Movie()
        {
            FavouriteLists = new HashSet<FavouriteList>();
            GenreMovies = new HashSet<GenreMovie>();
            Ratings = new HashSet<Rating>();
            ShowtimeOrders = new HashSet<ShowtimeOrder>();
            Showtimes = new HashSet<Showtime>();
        }

        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int Duration { get; set; }
        public string Actor { get; set; }
        public DateTime StartDate { get; set; }
        public int? AgeLimit { get; set; }
        public string Description { get; set; }
        public string Trailer { get; set; }
        public bool? Status { get; set; }
        public string Img { get; set; }
        public double? Price { get; set; }

        public virtual AgeLimit AgeLimitNavigation { get; set; }
        public virtual ICollection<FavouriteList> FavouriteLists { get; set; }
        public virtual ICollection<GenreMovie> GenreMovies { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<ShowtimeOrder> ShowtimeOrders { get; set; }
        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
