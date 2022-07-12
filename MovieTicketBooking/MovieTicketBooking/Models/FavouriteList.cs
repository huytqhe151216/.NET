using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class FavouriteList
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? MovieId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
