using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class AgeLimit
    {
        public AgeLimit()
        {
            Movies = new HashSet<Movie>();
        }

        public int AgeLimitId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
