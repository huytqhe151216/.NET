using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketBooking.Logics;
using MovieTicketBooking.Mail;
using MovieTicketBooking.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace MovieTicketBooking.Controllers
{
    public class UserController : Controller
    {
        readonly MovieTicketBookingContext context = new();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var setting = new JsonSerializerSettings();
            setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            var isLogin = context.Accounts.SingleOrDefault(x => x.Email.Equals(email.Trim()) && x.Password.Equals(password.Trim()));

            if (isLogin == null)
            {
                ViewBag.Message = "Email hoặc mật khẩu không chính xác.";
                return View();
            }
            else
            {
                if ((bool)!isLogin.IsActive)
                {
                    ViewBag.Message = "Hãy kiểm tra mail để xác thực tài khoản.";
                    return View();
                }
                else
                {
                    Account account = context.Accounts.Include(x => x.Customer).SingleOrDefault(x => x.Email.Equals(email.Trim()) && x.Password.Equals(password.Trim()));
                    HttpContext.Session.SetString("Account", JsonConvert.SerializeObject(account, setting));
                    return RedirectToAction("Index", "Home");
                }

            }

        }
        [HttpPost]
        public IActionResult Register(string email, string password, string name, string rePassword, string phone)
        {
            bool isRegister = false;

            foreach (var account in context.Accounts)
            {
                if (account.Email.Equals(email.Trim()))
                {
                    isRegister = true;
                    break;
                }
            }
            if (isRegister)
            {
                ViewBag.Message = "Email đã tồn tại, vui lòng kiểm tra lại";
            }
            else
            {
                if (!password.Trim().Equals(rePassword.Trim()))
                {
                    ViewBag.Message = "Nhập lại mật khẩu không chính xác";
                }
                else
                {
                    Account a = new Account
                    {
                        Email = email,
                        Password = password
                    };
                    context.Accounts.Add(a);
                    context.SaveChanges();
                    Customer c = new Customer()
                    {
                        CustomerId = a.AccountId,
                        CustomerName = name,
                        Phone = phone,
                    };
                    context.Customers.Add(c);
                    context.SaveChanges();
                    Account thisAccount = context.Accounts.SingleOrDefault(a => a.Email.Equals(email.Trim()));
                    try
                    {
                        MailHelper.SendMail(email, "Xác minh đăng ký tài khoản MovieTicketBooking", $"Cảm ơn bạn đã sử dụng dịch vụ của MovieTicketBooking. Click vào đây để xác minh tài khoản: <br> http://localhost:15167/User/Verify?email={email}&&code={thisAccount.Code}");
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Không thể gửi email.";
                        context.Remove(c);
                        context.Remove(thisAccount);
                        context.SaveChanges();
                        return View();
                    }
                    ViewBag.Message = "Hãy kiểm tra email để xác minh tài khoản.";
                }
            }

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Verify(string code, string email)
        {
            Account account = context.Accounts.FirstOrDefault(a => a.Email.Equals(email.Trim()));
            if (code.Equals(account.Code.ToString()))
            {
                account.IsActive = true;
                context.SaveChanges();
                return View();
            }
            else
            {

            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Account");
            return Redirect("/Home/Index");
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult ChangePassword(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {
            var setting = new JsonSerializerSettings();
            setting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            if (HttpContext.Session.GetString("Account") == null)
            {
                return Redirect("/Home/Index");
            }
            else
            {
                string json = HttpContext.Session.GetString("Account");
                Account account = JsonConvert.DeserializeObject<Account>(json);
                if (!account.Password.Equals(CurrentPassword.Trim()))
                {
                    ViewBag.Message = "Mật khẩu hiện tại không chính xác";
                    return View();
                }
                else if (!NewPassword.Trim().Equals(ConfirmPassword.Trim()))
                {
                    ViewBag.Message = "Nhập lại mật khẩu không chính xác";
                    return View();
                }
                else
                {
                    try
                    {
                        account.Password = NewPassword;
                        context.Accounts.Update(account);
                        context.SaveChanges();
                        ViewBag.Message = "Đổi mật khẩu  thành công";
                        HttpContext.Session.SetString("Account", JsonConvert.SerializeObject(account,setting));
                        return View();
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Đổi mật khẩu không thành công";
                        return View();
                    }
                }
            }
        }

    }
}
