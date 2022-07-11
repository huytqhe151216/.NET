using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp1;
namespace DemoColections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(new Account("name", "pass"));
                
            list.Add(new Employee("name1", "name1", 2001, "admin"));

            Account a = (Account)list[0];

            List<Account> list2 = new List<Account>();

            list2.Add(new Account("test", "test"));

            Account b = list2[0];

            Console.WriteLine(b);
        }
    }
}
