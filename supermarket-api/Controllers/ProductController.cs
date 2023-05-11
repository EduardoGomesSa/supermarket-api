using Microsoft.AspNetCore.Mvc;
using supermarket.application;
using supermarket.data.contexts;
using supermarket.model;

namespace supermarket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Store([FromBody]Product product)
        {
            var productHandler = new ProductHandler();

            var saved = productHandler.Add(product);

            if(saved) return Ok("Produto cadastrado com sucesso");

            return BadRequest("Não foi possivel cadastrar o produto");
        }
    }
}
