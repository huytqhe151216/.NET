using BtNorthwind.Logics;
using BtNorthwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
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
            if (totalProduct % itemPerPage == 0)
            {
                numberOfPage = totalProduct / itemPerPage;
            }
            else
            {
                numberOfPage = (int)totalProduct / itemPerPage + 1;
            }
            if (CurentPage < 1)
            {
                CurentPage = 1;
            }
            if (CurentPage > numberOfPage)
            {
                CurentPage = numberOfPage;
            }
            List<Category> categories = CetegoryLogic.GetAllCategories();
            List<Product> products = ProductLogic.GetProductByCategoryID(categoryId, (CurentPage - 1) * itemPerPage, itemPerPage);
            string categoryName = "all category";
            if (categoryId!=0)
            {
                categoryName = CetegoryLogic.GetCategoryName(categoryId).CategoryName;
            }
            ViewData["categoryName"] = categoryName;
            ViewData["countCart"] = countCart;
            ViewData["categoryId"] = categoryId;
            ViewData["numberOfPage"] = numberOfPage;
            ViewData["currentPage"] = CurentPage;
            ViewData["categories"] = categories;
            ViewData["currentPage"] = CurentPage;
            ViewData["countCart"] = countCart;
            return View(products);
        }
        public IActionResult Cart()
        {
            var session = HttpContext.Session;
            List<Cart> carts = new List<Cart>();
            if (session.GetString("Cart") != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
                double total = 0;
                foreach (Cart cart in carts)
                {
                    total += Convert.ToSingle(cart.ToPrice());
                }
                ViewData["total"] = total;
            }
            return View(carts);
        }
        public IActionResult AddtoCart(int productId, int categoryId, int page)
        {
            var session = HttpContext.Session;
            Product product = ProductLogic.GetProductByID(productId);
            if (product != null && product.UnitsInStock > 0)
            {
                if (session.Get("Cart") == null)
                {
                    Cart cart = new Cart(product, 1);
                    List<Cart> carts = new List<Cart>();
                    carts.Add(cart);
                    string json = JsonConvert.SerializeObject(carts);
                    session.SetString("Cart", json);
                }
                else
                {
                    List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
                    bool isExist = false;
                    foreach (Cart cart in carts)
                    {
                        if (cart.Product.ProductId == productId)
                        {
                            cart.quantity++;
                            isExist = true;
                        }
                    }
                    if (!isExist)
                    {
                        Cart cart = new Cart(product, 1);
                        carts.Add((Cart)cart);
                    }
                    string json = JsonConvert.SerializeObject(carts);
                    session.SetString("Cart", json);
                }
            }
            return Redirect($"/Product/List/?categoryId={categoryId}&page={page}");
        }
        public IActionResult Add(int productId, int quantity)
        {
            var session = HttpContext.Session;
            List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
            
            foreach (Cart cart in carts)
            {
                if (cart.Product.ProductId.Equals(productId))
                {
                    if (cart.quantity == 1 && quantity == -1)
                    {
                        
                    }
                    else if (cart.quantity == cart.Product.UnitsInStock && quantity == +1)
                    {

                    }
                    else { cart.quantity += quantity; }
                }
            }
            string json = JsonConvert.SerializeObject(carts);
            session.SetString("Cart", json);
            return Redirect("/Product/Cart");
        }
        public IActionResult Order()
        {
            var session = HttpContext.Session;
            List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Cart"));
            using (var context = new NorthwindContext())
            {
                int orderId = 0;
                Order order = new() { OrderDate = System.DateTime.Now };
                context.Add<Order>(order);
                context.SaveChanges();
                Order o1 = context.Orders.OrderByDescending(x => x.OrderId).FirstOrDefault();
                int orderDetailId = o1.OrderId;
                foreach (Cart cart in carts)
                {
                    OrderDetail od = new()
                    {
                        OrderId = orderDetailId,
                        ProductId = cart.Product.ProductId,
                        UnitPrice = (decimal)cart.Product.UnitPrice,
                        Quantity = (short)cart.quantity,
                    };
                    context.Add<OrderDetail>(od);
                    context.SaveChanges();
                    Product p = context.Products.FirstOrDefault(x => x.ProductId == cart.Product.ProductId);
                    p.UnitsInStock = (short)(p.UnitsInStock -  cart.quantity);
                    context.SaveChanges();
                }
            }
            session.Remove("Cart");
            return Redirect("/Product/List");
        }
    }


}
