using BtNorthwind.Models;
using System.Collections.Generic;
using System.Linq;

namespace BtNorthwind.Logics
{
    public class CetegoryLogic
    {
        public static List<Category> GetAllCategories()
        {
            using(var context  = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }
        public static Category GetCategoryName(int categoryId)
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Where(c => c.CategoryId == categoryId).FirstOrDefault();
            }
        }
    }
}
