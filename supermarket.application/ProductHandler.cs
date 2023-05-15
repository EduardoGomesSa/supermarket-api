using Microsoft.EntityFrameworkCore;
using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.application
{
    public class ProductHandler
    {

        public List<Product> Get()
        {
            var products = new List<Product>();

            using (var context = new ApplicationContext())
            {
                products = context.Products.ToList();
            }

            return products;
        }

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
                    var entry = context.Products.Remove(product);

                    productDeleted = context.SaveChanges() > 0;
                }

                var existProductInCategory = context.Products.FirstOrDefault(p => p.CategoryId == product.CategoryId);

                if(existProductInCategory!= null)
                {
                    var category = context.Categories.FirstOrDefault(c => c.Id == product.CategoryId);

                    var entry = context.Categories.Remove(category);

                    context.SaveChanges();
                }
            }

            return productDeleted;
        }
    }
}
