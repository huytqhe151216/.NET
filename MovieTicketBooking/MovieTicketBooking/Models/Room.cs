using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Room
    {
        public Room()
        {
            Showtimes = new HashSet<Showtime>();
        }

        public int RoomId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
