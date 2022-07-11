using BtNorthwind.Models;
using System.Collections.Generic;
using System.Linq;

namespace BtNorthwind.Logics
{
    public class OrderLogic
    {
        public static List<Order>  GetOrderByEmployeeID(int id)
        {
            using ( var context = new NorthwindContext())
            {
                return context.Orders.Where(o=>o.EmployeeId==id).ToList();
            }
        }
    }
}
