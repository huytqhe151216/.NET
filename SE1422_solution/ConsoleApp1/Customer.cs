using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer : Account
    {
        public DateTime DOB { get; set; }
        public string Name { get; set; }
        public Customer()
        {
        }

        public Customer(string username,string password,string name, DateTime dOB)
            : base(username, password)
        {
            DOB = dOB;
            Name = name;
        }
        public new void Input()
        {
            base.Input();
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Date of birth: ");
                    DOB = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. Enter again: ");
                }
            }
        }

        public override string ToString()
        {
            return $"Customer: {base.ToString()} - {Name} - {DOB}";
        }
    }
}
