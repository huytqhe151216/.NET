using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using Newtonsoft.Json;

namespace MovieTicketBooking.Controllers
{
    public class CustomerController : Controller
    {
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
        public IActionResult Profile()
        {
            return View();
        }

    }
}
