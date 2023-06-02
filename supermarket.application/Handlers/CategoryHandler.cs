using Microsoft.EntityFrameworkCore;
using supermarket.application.Convertions;
using supermarket.application.Interfaces;
using supermarket.application.Requests;
using supermarket.model;
using supermarket.service.Interfaces;

namespace supermarket.application.Handlers
{
    public class CategoryHandler : ICategoryHandler
    {
        private readonly ICategoryService _categoryService;

        public CategoryHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> Get()
        {
            return _categoryService.Get();
        }

        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        public bool Update(int id, CategoryPutRequest categoryPutRequest)
        {
            return _categoryService.Update(id, Mapper.toCategory(categoryPutRequest));
        }
    }
}
