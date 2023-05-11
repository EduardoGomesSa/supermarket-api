using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.application
{
    public class ProductHandler
    {
        public void Add(Product product)
        {
            using (var context = new ApplicationContext())
            {
                context.Products.Add(product);

                context.SaveChanges();
            }
        }
    }
}
