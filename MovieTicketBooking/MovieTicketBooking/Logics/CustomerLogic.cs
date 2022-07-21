using Microsoft.EntityFrameworkCore;
using MovieTicketBooking.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketBooking.Logics
{
    public class CustomerLogic
    {
        
        public static  Customer GetCustomerById(int id)
        {
            using (var context = new MovieTicketBookingContext())
            {
                return context.Customers.SingleOrDefault(x => x.CustomerId == id);
            }
            
        }
        public static List<Customer> GetListCustomer(int offset, int fetchnext)
        {
            List<Customer> list = new List<Customer>();
            using (var context = new MovieTicketBookingContext())
            {
                return context.Customers.Skip(offset).Take(fetchnext).ToList();
            }
            
        }
        public static int countCustomer()
        {
            using (var context = new MovieTicketBookingContext())
            {
                return context.Customers.Count();
            }
        }
    }
}
