using supermarket.application.Requests;
using supermarket.model;

namespace supermarket.application.Interfaces
{
    public interface IProductHandler
    {
        List<Product> Get();
        Product GetById(int id);
        bool Add(ProductPostRequest productPostRequest);
        bool Delete(int id);
        bool Update(int id, ProductPutRequest productPutRequest);
    }
}
