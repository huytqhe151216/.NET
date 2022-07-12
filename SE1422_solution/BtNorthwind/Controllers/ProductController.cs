using BtNorthwind.Logics;
using BtNorthwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BtNorthwind.Controllers
{
    public class ProductController : Controller
    {
        public int itemPerPage = 10;
        public int CurentPage = 1;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int categoryId, int page)
        {
            var session = HttpContext.Session;
            int countCart = 0;
            CurentPage = page;
            int numberOfPage = 0;
            if (session.Get("Cart") != null)
            {
                List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
                countCart = carts.Count();
            }
            int totalProduct = ProductLogic.GetTotalProductByCategoryID(categoryId);
            if (totalProduct%itemPerPage==0)
            {
                numberOfPage = totalProduct/itemPerPage;
            }
            else
            {
                numberOfPage = (int)totalProduct / itemPerPage + 1;
            }
            if (CurentPage<1)
            {
                CurentPage = 1;
            }
            if (CurentPage>numberOfPage)
            {
                CurentPage = numberOfPage;
            }
            List<Category> categories = CetegoryLogic.GetAllCategories();
            List<Product> products = ProductLogic.GetProductByCategoryID(categoryId,(CurentPage-1)*itemPerPage,itemPerPage);

            ViewData["countCart"] = countCart;
            ViewData["categoryId"] = categoryId;
            ViewData["numberOfPage"] = numberOfPage;
            ViewData["currentPage"] = CurentPage;
            ViewData["categories"] = categories;
            ViewData["currentPage"] = CurentPage;
            ViewData["countCart"] = countCart;
            return View(products);
        }
    }
}
