using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Rating
    {
        public int RateId { get; set; }
        public int? MovieId { get; set; }
        public int? CustomerId { get; set; }
        public int? Star { get; set; }
        public string ContentRate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
