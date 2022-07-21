using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieTicketBooking.Controllers
{
    public class AdminController : Controller
    {
        IWebHostEnvironment _env;
        public AdminController(IWebHostEnvironment env)
        {
            _env = env;
        }
        readonly MovieTicketBookingContext context = new();
        public bool test()
        {
            return AccountLogic.CheckEmailExist("huyheotmhp20");
        }
        [HttpPost]
        public IActionResult CreateEmployeeAccount(string name, string email, string phone, string password, string rePassword)
        {
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                if (AccountLogic.CheckEmailExist(email))
                {
                    ViewBag.Message = "Email đã tồn tại";
                }
                else
                {
                    if (!password.Trim().Equals(rePassword.Trim()))
                    {
                        ViewBag.Message = "Nhập lại mật khẩu không chính xác";
                    }
                    else
                    {
                        Account a = new Account()
                        {
                            RoleId = 2,
                            Email = email,
                            Password = password,
                            IsActive = true
                        };
                        context.Add(a);
                        context.SaveChanges();
                        Employee e = new Employee()
                        {
                            EmployeeId = a.AccountId,
                            Name = name,
                            Phone = phone,

                        };
                        context.Add(e);
                        context.SaveChanges();
                        ViewBag.Message = "Đăng ký tài khoản thành công";
                    }

                }
                return View();
            }
            else
            {
                Redirect("/Home/Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateEmployeeAccount()
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");

            }
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                return View();
            }
            else
            {
                return Redirect("/Home/Index");

            }

        }
        [HttpGet]
        public IActionResult AddNewMovie()
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");

            }
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                using (var context = new MovieTicketBookingContext())
                {
                    List<Genre> genres = context.Genres.OrderBy(x => x.GenreId).ToList();
                    List<AgeLimit> ageLimits = context.AgeLimits.OrderBy(x => x.AgeLimitId).ToList();
                    ViewBag.ListGenres = genres;
                    ViewBag.AgeLimits = ageLimits;
                }
                return View();
            }
            else
            {
                return Redirect("/Home/Index");

            }
        }
        [HttpPost]
        public IActionResult AddNewMovie(string name, string actor, int[] genre, int duration, DateTime startDate, string description, string trailer, int ageLimit, int price, IFormFile image)
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");

            }
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                try
                {
                    using (var context = new MovieTicketBookingContext())
                    {
                        List<Genre> genres = context.Genres.OrderBy(x => x.GenreId).ToList();
                        List<AgeLimit> ageLimits = context.AgeLimits.OrderBy(x => x.AgeLimitId).ToList();
                        ViewBag.ListGenres = genres;
                        ViewBag.AgeLimits = ageLimits;
                    }
                    string imageName = "";
                    if (image != null)
                    {
                        imageName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
                        var imagePath = Path.Combine(_env.WebRootPath, "movie", "images", imageName);
                        if (!Directory.Exists(Path.GetDirectoryName(imagePath)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(imagePath));
                        }
                        using (var stream = new FileStream(imagePath, FileMode.Create))
                        {
                            image.CopyTo(stream);
                        }
                    }
                    Movie m = new Movie()
                    {
                        MovieName = name,
                        Actor = actor,
                        Description = description,
                        Duration = duration,
                        StartDate = startDate,
                        Trailer = trailer,
                        Img = imageName,
                        Price = price,
                        Status = true,
                        AgeLimit = ageLimit
                    };
                    context.Add(m);
                    context.SaveChanges();
                    foreach (int x in genre)
                    {
                        GenreMovie genreMovie = new GenreMovie()
                        {
                            GenreId = x,
                            MovieId = m.MovieId
                        };
                        context.Add(genreMovie);
                        context.SaveChanges();
                    }
                    ViewBag.Message = "Thêm thành công";
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Thêm thất bại";
                    return View();
                }
            }
            else
            {
                return Redirect("/Home/Index");

            }
        }
        public IActionResult ManageEmployee()
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");

            }
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                List<Employee> employees = new List<Employee>();
                employees = context.Employees.ToList();
                return View(employees);
            }
            else
            {
                return Redirect("/Home/Index");

            }
        }
        [HttpGet]
        public IActionResult ManageCustomer(int page)
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");

            }
            string json = HttpContext.Session.GetString("Account");
            Account account = JsonConvert.DeserializeObject<Account>(json);
            if (account.RoleId == 3)
            {
                int currentPage = page;
                int numberCustomer = CustomerLogic.countCustomer();
                int numberPage = numberCustomer % 10 == 0 ? (numberCustomer / 10) : (numberCustomer / 10 + 1);
                if (currentPage == 0)
                {
                    currentPage = 1;
                }
                else
                {
                    if (currentPage == numberPage + 1)
                    {
                        currentPage = numberPage;
                    }
                }
                ViewBag.currentPage = currentPage;
                List<Customer> customers = new List<Customer>();
                customers = CustomerLogic.GetListCustomer((currentPage - 1) * 10, 10);

                ViewBag.numberPage = numberPage;

                return View(customers);
            }
            else
            {
                return Redirect("/Home/Index");

            }
        }
        public IActionResult AddMoney(int cid, int money)
        {
            Customer c = CustomerLogic.GetCustomerById(cid);
            c.BalanceInWallet += money;
            context.Update(c);
            context.SaveChanges();
            return Redirect("/Admin/ManageCustomer");
        }
        public IActionResult Active(int accountId)
        {
            Account account = AccountLogic.GetAccountById(accountId);
            account.IsActive = ((bool)account.IsActive) ? false : true;
            context.Update(account);
            context.SaveChanges();
            if (account.RoleId==1)
            {
                return Redirect("/Admin/ManageCustomer");
            }
            else if(account.RoleId==2)
            {
                return Redirect("/Admin/ManageEmployee");
            }
            return Redirect("/Home/Index");
        }

    }
}
