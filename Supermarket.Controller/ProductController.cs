using supermarket.data.contexts;
using supermarket.model;

namespace supermarket.controller
{
    public class ProductController
    {
        public void Add()
        {
            using (var context = new ApplicationContext())
            {
                Product product = new Product(
                        id: 0,
                        name: "Shampoo",
                        description: "Bem leve e cheiroso",
                        price: 10.30m,
                        amount: 100,
                        new Category(id: 0, name: "creme")
                );

                context.Products.Add( product );

                context.SaveChanges();
            }
        }





    }
}
