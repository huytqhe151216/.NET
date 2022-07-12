using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Print
    {
        public int PrintId { get; set; }
        public int? TicketId { get; set; }
        public int? EmployeeId { get; set; }
        public bool IsPrinted { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
