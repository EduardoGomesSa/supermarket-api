using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.application
{
    public class ProductHandler
    {
        public bool Add(Product product)
        {
            var productSaved = false;

            using (var context = new ApplicationContext())
            {
                var category = context.Categories.FirstOrDefault(c => c.Name == product.Category.Name);

                if (category != null)
                {
                    product.CategoryId = category.Id;
                }
                else
                {
                    category = new Category { Name = product.Category.Name };
                    context.Categories.Add(category);
                    context.SaveChanges();

                    product.CategoryId = category.Id;
                }

                context.Products.Add(product);

                productSaved = context.SaveChanges() > 0;
            }

            return productSaved;
        }

        public bool Delete(int id)
        {
            var productDeleted = false;

            using (var context = new ApplicationContext())
            {
                var product = context.Products.FirstOrDefault(p => p.Id == id);

                if (product != null)
                {
                    productDeleted = context.Products.Remove(product);
                }
            }

            return productDeleted;
        }
    }
}
