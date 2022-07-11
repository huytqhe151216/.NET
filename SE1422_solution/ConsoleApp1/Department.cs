using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UsernameDuplicateExeption : Exception
    {
        public UsernameDuplicateExeption(String s) : base(s) 
        {
            Console.WriteLine(s);
        }
    }
    public class Department : IDisplayable
    {
        private List<Account> accounts;
        public string DepartmentName { get; set; }

        public void Display()
        {
            Console.WriteLine($"List account in Department: {DepartmentName}");
            foreach (var account in accounts)
            {

                Console.WriteLine($"{account.Username} - {account.Password}");
            }
        }

        public Department()
        {
            accounts = new List<Account>();
        }
        public int GetNumberOfAccount() { return accounts.Count; }
        public void AddAccount (Account a)
        {
            if (accounts.Contains(a))
            {
                //Console.WriteLine("Account already exists");
                throw new UsernameDuplicateExeption($"Account ${a.Username} exist.");
                
            }
            else
            {
                accounts.Add(a);
                Console.WriteLine($"Add account {a.Username} successfully.");
            }
        }
        public void RemoveAccount(Account a)
        {
            if (accounts == null)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                if (accounts.Contains(a))
                {
                    accounts.Remove(a);
                    Console.WriteLine("This account have been removed");
                }
            }

            //accounts.Remove(a);
        }
        public Account GetAccount(string usename)
        {
            foreach (var account in accounts)
            {
                if (account.Username.Equals(usename))
                {
                    return account;
                }
            }
            return null;
        }
        public string InputString(string message, string error)
        {
            while (true)
            {
                Console.WriteLine(message);
                string inputString = Console.ReadLine();
                if(!string.IsNullOrEmpty(inputString)) return inputString;
                Console.WriteLine(error);
            }
        }
        public void Input()
        {
            DepartmentName = InputString("enter DepartmentName", "DepartmentName is not null. Enter again");
            while (true)
            {
                Account account = new Account(InputString("Enter Username: ", "Username is not null"), InputString("Enter Password: ", "Password is not null"));
                AddAccount(account);
                if (InputString("Do you want continue add (Y/n): ", "Not empty. Enter again").ToLower().Equals("n")) return;
            }
        }
        public static int SortByName(Account x , Account y)
        {
            return x.Username.CompareTo(y.Username);
        }
        
        public void SortUsingDelegate()
        {
            accounts.Sort(SortByName);
            accounts.Sort(
                delegate(Account a, Account b)
                {
                    return a.Username.CompareTo(b.Username);
                }
                );
            //lambda expression
            accounts.Sort(
                    (a,b)=> a.Username.CompareTo(b.Username)                
                );

        }
        
        //public override string ToString()
        //{
        //    return $"Employee|{Username}|{Password}|{Salary}|{Role}";
        //}
        public int Menu()
        {
            Console.WriteLine("1.Get number of account");
            Console.WriteLine("2.Add Account");
            Console.WriteLine("3.Remove account");
            Console.WriteLine("4.Display account");
            Console.WriteLine("5.Sort account by username");
            Console.WriteLine("6.Sort account by type");
            Console.WriteLine("7.Exit");
            Console.Write("Enter your choice: ");
            while (true)
            {
                string number = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 7)
                    {
                        return num;
                    }
                    Console.WriteLine("Choice must in [1-7]: ");

                }
                catch
                {
                    Console.WriteLine("Choice must is number");
                }
            }
        }
        public void ReadFromFile(String FileName)
        {
            try
            {
                StreamReader reader = new StreamReader(FileName);
                String[] departmentName = reader.ReadLine().Split(':');
                if (departmentName.Length == 2 && string.Equals(departmentName[0].Trim(), "department", StringComparison.OrdinalIgnoreCase))
                {
                    DepartmentName = departmentName[1].Trim();
                }
                else
                {
                    Console.WriteLine("Wrong format department name");
                    return;
                }
                String line;
                while ((line = reader.ReadLine()) != null)
                {   
                    String[] temp = line.Split('|');
                    if (temp.Length ==3 && string.Equals(temp[0], "account" , StringComparison.OrdinalIgnoreCase)) 
                    {
                        try
                        {
                            Account account = new Account();
                            account.Username = temp[1].Trim();
                            account.Password = temp[2].Trim();
                            AddAccount(account);
                        }
                        catch (ArgumentException )
                        {
                            Console.WriteLine($"{temp[1].Trim()} error row");
                        }
                    }
                    if (temp.Length == 5 && string.Equals(temp[0].Trim(), "employee", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Employee employee = new Employee();
                            employee.Username = temp[1].Trim();
                            employee.Password = temp[2].Trim();
                            employee.Salary = Convert.ToDouble(temp[3].Trim());
                            employee.Role = temp[4].Trim();
                            AddAccount(employee);
                        }
                        catch (FormatException )
                        {
                            Console.WriteLine($"{temp[1].Trim()} error parse salary");
                        }
                    }
                    if (temp.Length == 5 && string.Equals(temp[0].Trim(), "customer", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            Customer customer = new Customer();
                            customer.Username = temp[1].Trim();
                            customer.Password = temp[2].Trim();
                            customer.Name = temp[3].Trim();
                            customer.DOB = DateTime.ParseExact(temp[4], "dd MMM yyyy", null);
                            AddAccount(customer);
                        }
                        catch (FormatException )
                        {
                            Console.WriteLine($"{temp[1].Trim()} error parse date");
                        }
                    }
                    
                }
                reader.Close();

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found - Message:" + e.Message);
                
            }
            catch(Exception )
            {
                Console.WriteLine("Something error");
            } 
        }
        public void WriteFromFile(string FileName)
        {
            try
            {

                StreamWriter writer = new StreamWriter(FileName, append: false);
                writer.WriteLine($"Department : {DepartmentName}");
                foreach (Account account in accounts)
                {
                    writer.WriteLine(account.ToString());
                }
                Console.WriteLine($"Write {accounts.Count()} account in {DepartmentName} to {FileName}");
                writer.Close();
            }
            catch (Exception )
            {
                Console.WriteLine("Something error");
            }

        }
    }
}
