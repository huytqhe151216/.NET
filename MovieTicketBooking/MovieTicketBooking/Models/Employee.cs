using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Prints = new HashSet<Print>();
            Tickets = new HashSet<Ticket>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual Account EmployeeNavigation { get; set; }
        public virtual ICollection<Print> Prints { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
