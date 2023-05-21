using Microsoft.EntityFrameworkCore;
using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.application.Handlers
{
    public class CategoryHandler
    {
        public List<Category> Get()
        {
            var categories = new List<Category>();

            using (var context = new ApplicationContext())
            {
                categories = context.Categories.ToList();
                //categories = context.Categories.Include(c => c.Products).ToList();
            }

            return categories;
        }

        public Category GetById(int id)
        {
            var category = new Category();

            using (var context = new ApplicationContext())
            {
                category = context.Categories.FirstOrDefault(c => c.Id == id);
            }

            return category;
        }

        public bool Update(int id, Category category)
        {
            var updeted = false;

            using (var context = new ApplicationContext())
            {
                var categoryExisting = context.Categories.FirstOrDefault(c => c.Id == id);

                if (categoryExisting != null)
                {
                    categoryExisting.Name = category.Name;
                }

                updeted = context.SaveChanges() > 0;
            }

            return updeted;
        }
    }
}
