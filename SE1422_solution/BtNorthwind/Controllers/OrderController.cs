using BtNorthwind.Logics;
using BtNorthwind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BtNorthwind.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult List()
        {
            List<Employee> listEmployees = new List<Employee>();
            listEmployees = EmployeeLogic.GetAllEmployee();
            
            return View(listEmployees);
        }
        public IActionResult Detail(int id)
        {
            List<Order> orders = OrderLogic.GetOrderByEmployeeID(id);
            Employee e = EmployeeLogic.GetEmployeeByEId(id);
            ViewData["employee"] = e;
            return View(orders);
        }
    }
}
