using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Genre
    {
        public Genre()
        {
            GenreMovies = new HashSet<GenreMovie>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<GenreMovie> GenreMovies { get; set; }
    }
}
