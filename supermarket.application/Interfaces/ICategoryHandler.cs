using supermarket.application.Requests;
using supermarket.model;

namespace supermarket.application.Interfaces
{
    public interface ICategoryHandler
    {
        List<Category> Get();
        Category GetById(int id);
        bool Update(int id, CategoryPutRequest categoryPutRequest);
    }
}
