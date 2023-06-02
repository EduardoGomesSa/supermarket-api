using supermarket.application.Requests;
using supermarket.model;

namespace supermarket.application.Convertions
{
    public static class Mapper
    {
        public static Product toProduct(ProductPostRequest productPostRequest)
        {
            return new Product()
            {
                Name = productPostRequest.Name,
                Description = productPostRequest.Description,
                Price = productPostRequest.Price,
                Amount = productPostRequest.Amount,
                Category = new Category
                {
                    Name = productPostRequest.Category.Name
                },
            };
        }

        public static Product toProduct(ProductPutRequest productPutRequest)
        {
            return new Product()
            {
                Name = productPutRequest.Name,
                Description = productPutRequest.Description,
                Price = productPutRequest.Price,
                Amount = productPutRequest.Amount
            };
        }

        public static Category toCategory(CategoryPutRequest categoryPutRequest)
        {
            return new Category()
            {
                Name = categoryPutRequest.Name
            };
        }
    }
}
