using Microsoft.EntityFrameworkCore;
using supermarket.application.Convertions;
using supermarket.application.Interfaces;
using supermarket.application.Requests;
using supermarket.model;
using supermarket.service.Interfaces;

namespace supermarket.application.Handlers
{
    public class ProductHandler : IProductHandler
    {
        private readonly IProductService _productService;

        public ProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
            return _productService.Get();
        }

        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        public bool Add(ProductPostRequest productPostRequest)
        {
            var product = Mapper.toProduct(productPostRequest);

            return _productService.Add(product);
        }

        public bool Delete(int id)
        {
            return _productService.Delete(id);
        }

        public bool Update(int id, ProductPutRequest productPutRequest)
        {
            var product = Mapper.toProduct(productPutRequest);

            return _productService.Update(id, product);
        }
    }
}
