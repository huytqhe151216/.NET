using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Account
    {
        protected string username;
        public string Username { get { return username; } set { username = value; } }
        protected string password; 
        public string Password { get { return password; } set { password = value; } }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }



        public void Input()
        {
            Console.WriteLine("Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();
        }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   username == account.username &&
                   password == account.password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(username, password);
        }

        public override string ToString()
        {
            return $"Account: {username} - {password}";
        }
    }
    class UsernameCompare : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Username.CompareTo(y.Username);
        }
    }
    class DataTypeCompare : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.GetType().Name.CompareTo(y.GetType().Name) ;
        }
    }
}
