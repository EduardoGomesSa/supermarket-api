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
            }

            return categories;
        }
    }
}
