using BtNorthwind.Models;
using System.Collections.Generic;
using System.Linq;

namespace BtNorthwind.Logics
{
    public class ProductLogic
    {
        public static List<Product> GetProductByCategoryID(int id, int offset, int fetchnext)
        {
            using(var context =  new NorthwindContext())
            {
                if (id ==0 )
                {
                    return context.Products.Skip(offset).Take(fetchnext).ToList();
                }
                else
                {
                    return  context.Products.Where(x=>x.CategoryId==id).Skip(offset).Take(fetchnext).ToList();
                }
            }
        }
        public static Product GetProductByID(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Where((x)=>x.ProductId==id).FirstOrDefault();
            }
        }
        public static int GetTotalProductByCategoryID(int id)
        {
            using( var context = new NorthwindContext())
            {
                if (id==0)
                {
                    return context.Products.Count();
                }
                else
                {
                    return context.Products.Where(x=>x.CategoryId==id).Count();
                }
            }
        }
    }
}
