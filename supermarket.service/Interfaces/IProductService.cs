using supermarket.model;

namespace supermarket.service.Interfaces
{
    public interface IProductService
    {
        List<Product> Get();
        Product GetById(int id);
        bool Add(Product product);
        bool Delete(int id);
        bool Update(int id, Product product);
    }
}
