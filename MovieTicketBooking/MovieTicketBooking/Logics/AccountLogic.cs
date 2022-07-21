using MovieTicketBooking.Models;
using System;
using System.Linq;

namespace MovieTicketBooking.Logics
{
    public class AccountLogic
    {
        public static Account GetAccountById(int id)
        {
            using (var context = new MovieTicketBookingContext())
            {
                return context.Accounts.FirstOrDefault(x=>x.AccountId==id);
            }
        }
        public static bool CheckEmailExist(string email)
        {
            using (var context = new MovieTicketBookingContext())
            {
                Account account = context.Accounts.FirstOrDefault(x => x.Email == email);
                if (account == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
           
        }
        
    }
}
