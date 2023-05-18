using Microsoft.EntityFrameworkCore;
using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.application
{
    public class CategoryHandler
    {
        public List<Category> Get()
        {
            var categories = new List<Category>();

            using(var context = new ApplicationContext())
            {
                categories = context.Categories.ToList();
                //categories = context.Categories.Include(c => c.Products).ToList();
            }

            return categories;
        }

        public Category GetById(int id)
        {
            var category = new Category();

            using(var context = new ApplicationContext())
            {
                category = context.Categories.FirstOrDefault(c => c.Id == id);
            }

            return category;
        }
    }
}
