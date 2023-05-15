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

        [HttpDelete]
        public IActionResult Destroy([FromHeader] int id)
        {
            var productHandler = new ProductHandler();

            var productDeleted = productHandler.Delete(id);

            if (productDeleted) return Ok("O produto foi excluído com sucesso");

            return BadRequest("Não foi possível excluir o produto");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var productHandler = new ProductHandler();

            var products = productHandler.Get();
            if(products.Count > 0) return Ok(products);

            return Ok("Não há nenhum produto cadastrado");
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            var productHandler = new ProductHandler();

            var productUpdated = productHandler.Update(id, product);

            if (productUpdated) return Ok("Produto atualizado com sucesso");

            return BadRequest("Não foi possível atualizar o produto");
        }
    }
}
