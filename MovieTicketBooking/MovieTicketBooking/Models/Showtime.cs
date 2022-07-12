using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Showtime
    {
        public Showtime()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int ShowtimeId { get; set; }
        public int? RoomId { get; set; }
        public int? MovieId { get; set; }
        public DateTime? Date { get; set; }
        public double? TimeFrom { get; set; }
        public int? Type { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
