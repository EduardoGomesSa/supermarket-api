using Microsoft.AspNetCore.Mvc;
using supermarket.application;

namespace supermarket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var categoryHandler = new CategoryHandler();

            var categories = categoryHandler.Get();

            if(categories.Count > 0) return Ok(categories);

            return Ok("Não tem nenhuma categoria cadastrada");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var categoryHandler = new CategoryHandler();

            var category = categoryHandler.GetById(id);

            if (category != null) return Ok(category);

            return Ok("categoria não existe");
        }
    }
}
