using BtNorthwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BtNorthwind.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ViewCart()
        {
            var session = HttpContext.Session;
            List<Cart> carts = new List<Cart>();
            if (session.GetString("Cart")!=null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
            }
            return View("View", carts);
        }

    }
}
