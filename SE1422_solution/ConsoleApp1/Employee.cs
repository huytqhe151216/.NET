using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee : Account
    {
        public Employee()
        {
        }

        public Employee(string username, string password, double salary, string role) : base(username, password)
        {
            Role = role;
            Salary = salary;
        }

        public string Role { get; set; }
            
        public double Salary
            { get; set; }

        public new void Input()
        {
            base.Input();
            Console.WriteLine("Role: ");
            Role = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Salary:");
                    Salary = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong format. Enter agian. ");
                   
                }
            }
        }

        public override string ToString()
        {
            return $"Employee: {base.ToString()} - {Salary} - {Role}";
        }
    } 
}
