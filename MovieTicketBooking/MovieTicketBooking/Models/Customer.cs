using System;
using System.Collections.Generic;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class Customer
    {
        public Customer()
        {
            FavouriteLists = new HashSet<FavouriteList>();
            Ratings = new HashSet<Rating>();
            ShowtimeOrders = new HashSet<ShowtimeOrder>();
            Tickets = new HashSet<Ticket>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? BalanceInWallet { get; set; }
        public string Phone { get; set; }
        public int? TotalTrade { get; set; }

        public virtual Account CustomerNavigation { get; set; }
        public virtual ICollection<FavouriteList> FavouriteLists { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<ShowtimeOrder> ShowtimeOrders { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
