using supermarket.model;

namespace supermarket.application.Interfaces
{
    public interface IProductHandler
    {
        List<Product> Get();
        Product GetById(int id);
        bool Add(Product product);
        bool Delete(int id);
        bool Update(int id, Product product);
    }
}
