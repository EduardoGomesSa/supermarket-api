using Microsoft.AspNetCore.Mvc;
using supermarket.application.Handlers;
using supermarket.application.Interfaces;
using supermarket.application.Requests;
using supermarket.data.contexts;
using supermarket.model;

namespace supermarket_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productHandler;

        public ProductController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }

        [HttpPost]
        public IActionResult Store([FromBody]ProductPostRequest productPostRequest)
        {
            var saved = _productHandler.Add(productPostRequest);

            if(saved) return Ok("Product successfully registered");

            return BadRequest("Failed to register the product");
        }

        [HttpDelete]
        public IActionResult Destroy([FromHeader] int id)
        {
            var productDeleted = _productHandler.Delete(id);

            if (productDeleted) return Ok("The product has been successfully deleted");

            return BadRequest("Failed to delete the product");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productHandler.Get();
            if(products.Count > 0) return Ok(products);

            return Ok("No product is registered");
        }

        [HttpGet("GetById")]
        public IActionResult GetById([FromHeader]int id)
        {
            var product = _productHandler.GetById(id);

            if (product != null) return Ok(product);

            return NotFound("Product don´t exist");
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] ProductPutRequest productPutRequest)
        {
            var productUpdated = _productHandler.Update(id, productPutRequest);

            if (productUpdated) return Ok("Product updated with success");

            return BadRequest("Product don´t updated");
        }
    }
}
