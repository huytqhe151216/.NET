using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account a = new Account("chilp", "123456");
            //Console.WriteLine("Account: ");
            //Console.WriteLine(a);
            //Console.WriteLine();

            //Employee e1 = new Employee("trungnb", "123457", 1200.4, "Admin");
            //Employee e2 = new Employee();
            //Console.WriteLine("Input Employee's info:");
            //e2.Input();
            //Console.WriteLine($"Employee: {e1}");
            //Console.WriteLine($"Employee: {e2}");
            //Console.WriteLine();

            //Customer c1 = new Customer("trungnb", "123457", "Bao Trung", new DateTime(1987, 12, 1));
            //Customer c2 = new Customer();
            //Console.WriteLine("Input Customer's info:");
            //c2.Input();
            //Console.WriteLine($"Customer: {c1}");
            //Console.WriteLine($"Customer: {c2}");
            //Console.ReadLine();



            Department department = new Department();
            department.ReadFromFile(@"C:\Users\ADMIN\source\repos\SE1422_solution\ConsoleApp1\department.txt");
            //department.SortUsingDelegate();
            department.Display();
            department.WriteFromFile(@"C:\Users\ADMIN\source\repos\SE1422_solution\ConsoleApp1\out.txt");

            //department.Input();
            //int choice;
            //Account account = new Account();
            //do
            //{
            //    choice = department.Menu();
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"Number of account is: {department.GetNumberOfAccount()}");
            //            break;
            //        case 2:
            //            while (true)
            //            {  
            //                account = new Account(department.InputString("Enter Username: ", "Username is not null"), department.InputString("Enter Password: ", "Password is not null"));
            //                department.AddAccount(account);
            //                if (department.InputString("Do you want continue add (Y/n): ", "Not empty. Enter again").ToLower().Equals("n")) break;
            //            }
            //            break;
            //        case 3:


            //            department.RemoveAccount(department.GetAccount(department.InputString("Enter Username: ", "Username is not null")));
            //            break;
            //        case 4:
            //            department.Display();
            //            break;
            //        case 5:
            //            department.Sort();
            //            Console.WriteLine("List account after sort by username: ");
            //            department.Display();
            //            break;
            //        case 6:
            //            Console.WriteLine("");
            //            break;
            //    }
            //} while (choice != 7);
        }

    }
}
