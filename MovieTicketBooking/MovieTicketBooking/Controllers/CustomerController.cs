using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MovieTicketBooking.Controllers
{
    public class CustomerController : Controller
    {
        IWebHostEnvironment _env;

        readonly MovieTicketBookingContext context = new();

        public CustomerController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public bool test()
        {
        
            return MovieLogic.CheckLoveMovieByCustomer(1, 9); ;
        }
        
        public IActionResult AddFavourite(int id)
        {
            var setting = new JsonSerializerSettings();
            setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string json = HttpContext.Session.GetString("Account");
            Account account = null;
            if (json != null)
            {
                account = JsonConvert.DeserializeObject<Account>(json, setting);
            }
            
            if (MovieLogic.CheckLoveMovieByCustomer(account.AccountId,id))
            {
                MovieLogic.DeleteFavouriteMovie(account.AccountId, id);
            }
            else
            {
                MovieLogic.InsertFavouriteMovie(account.AccountId, id);
            }
            return Redirect("/Movie/Detail/"+id);
        }
        [HttpGet]
        public IActionResult Profile()
        {
            string json = HttpContext.Session.GetString("Account");
            if (json==null)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                Account account = JsonConvert.DeserializeObject<Account>(json);
                ViewBag.Account = account;
                return View(CustomerLogic.GetCustomerById(account.AccountId));
            }
            
        }
        public IActionResult Profile(string name, string phone)
        {

            string json = HttpContext.Session.GetString("Account");
            if (json == null)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                Account account = JsonConvert.DeserializeObject<Account>(json);
                ViewBag.Account = account;
                Customer c = CustomerLogic.GetCustomerById(account.AccountId);
                c.CustomerName = name;
                c.Phone = phone;
                context.Customers.Update(c);
                context.SaveChanges();
                return View(c);
            }
        }
        public IActionResult EditImage(IFormFile image)
        {
            if (image!=null)
            {
                var imageName = Guid.NewGuid().ToString()+Path.GetExtension(image.FileName);
                var imagePath = Path.Combine(_env.WebRootPath,"customer","images",imageName);
                if (!Directory.Exists(Path.GetDirectoryName(imagePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(imagePath));
                }
                using(var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                string json = HttpContext.Session.GetString("Account");
                Account account = JsonConvert.DeserializeObject<Account>(json);
                Customer c = CustomerLogic.GetCustomerById(account.AccountId);
                c.Img = imageName;
                context.Update(c);
                context.SaveChanges();

            }
            
            return Redirect("/Customer/Profile");
        }

    }
}
