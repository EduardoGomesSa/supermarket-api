using Microsoft.AspNetCore.Mvc;
using supermarket.application.Handlers;
using supermarket.application.Interfaces;
using supermarket.application.Requests;
using supermarket.model;

namespace supermarket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryHandler _categoryHandler;

        public CategoryController(ICategoryHandler categoryHandler)
        {
            _categoryHandler = categoryHandler;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryHandler.Get();

            if(categories.Count > 0) return Ok(categories);

            return Ok("No category is registered");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var category = _categoryHandler.GetById(id);

            if (category != null) return Ok(category);

            return Ok("category don't exist");
        }

        [HttpPut]
        public IActionResult Put([FromHeader]int id, [FromBody] CategoryPutRequest categoryPutRequest)
        {
            var categoryUpdeted = _categoryHandler.Update(id, categoryPutRequest);

            if(categoryUpdeted) return Ok("Category updeted with sucess");

            return BadRequest("Category don´t updated");
        }
    }
}
