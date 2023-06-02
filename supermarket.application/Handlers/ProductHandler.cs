using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using supermarket.application.Interfaces;
using supermarket.data.contexts;
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

        public bool Add(Product product)
        {
            return _productService.Add(product);
        }

        public bool Delete(int id)
        {
            return _productService.Delete(id);
        }

        public bool Update(int id, Product product)
        {
            return _productService.Update(id, product);
        }
    }
}
