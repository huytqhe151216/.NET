using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class ShowtimeOrder
    {
        public int OrderId { get; set; }
        public int? MovieId { get; set; }
        public DateTime? Date { get; set; }
        public double? TimeFrom { get; set; }
        public int? CustomerId { get; set; }
        public int TypeOrder { get; set; }
        public bool IsApproved { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
