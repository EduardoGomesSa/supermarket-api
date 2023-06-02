using Microsoft.EntityFrameworkCore;
using supermarket.application.Interfaces;
using supermarket.data.contexts;
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

        public bool Update(int id, Category category)
        {
            return _categoryService.Update(id, category);
        }
    }
}
