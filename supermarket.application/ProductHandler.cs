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
                context.Products.Add(product);

                productSaved = context.SaveChanges() > 0;
            }

            return productSaved;
        }
    }
}
