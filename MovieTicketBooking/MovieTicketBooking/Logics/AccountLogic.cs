using MovieTicketBooking.Models;
using System;
using System.Linq;

namespace MovieTicketBooking.Logics
{
    public class AccountLogic
    {
        public readonly MovieTicketBookingContext context = new();
        public  bool ChangePassword(string email, string newPassword)
        {
            try
            {
                Account account = context.Accounts.SingleOrDefault(x => x.Email.Equals(email));
                account.Password = newPassword;
                context.Accounts.Update(account);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
