using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Prints = new HashSet<Print>();
        }

        public int TicketId { get; set; }
        public int? ShowtimeId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? TimeOrder { get; set; }
        public string Place { get; set; }
        public bool? IsSold { get; set; }
        public string Code { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Showtime Showtime { get; set; }
        public virtual ICollection<Print> Prints { get; set; }
    }
}
