using supermarket.model;

namespace supermarket.service.Interfaces
{
    public interface ICategoryService
    {
        List<Category> Get();
        Category GetById(int id);
        bool Update(int id, Category category);
    }
}
