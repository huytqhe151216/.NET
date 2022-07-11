using BtNorthwind.Models;
using System.Collections.Generic;
using System.Linq;

namespace BtNorthwind.Logics
{
    public class EmployeeLogic
    {
        public static List<Employee> GetAllEmployee()
        {
            using(var context  = new NorthwindContext())
            {
                return context.Employees.ToList();
            }
        }
        public  static Employee GetEmployeeByEId(int id)
        {
            using(var context = new NorthwindContext())
            {
                return context.Employees.FirstOrDefault(e=>e.EmployeeId == id);
            }
        }
    }
}
