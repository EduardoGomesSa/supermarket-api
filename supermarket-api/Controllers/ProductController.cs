﻿using Microsoft.AspNetCore.Mvc;
using supermarket.application.Handlers;
using supermarket.application.Interfaces;
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
        public IActionResult Store([FromBody]Product product)
        {
            var saved = _productHandler.Add(product);

            if(saved) return Ok("Produto cadastrado com sucesso");

            return BadRequest("Não foi possivel cadastrar o produto");
        }

        [HttpDelete]
        public IActionResult Destroy([FromHeader] int id)
        {
            var productDeleted = _productHandler.Delete(id);

            if (productDeleted) return Ok("O produto foi excluído com sucesso");

            return BadRequest("Não foi possível excluir o produto");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productHandler.Get();
            if(products.Count > 0) return Ok(products);

            return Ok("Não há nenhum produto cadastrado");
        }

        [HttpGet("GetById")]
        public IActionResult GetById([FromHeader]int id)
        {
            var product = _productHandler.GetById(id);

            if (product != null) return Ok(product);

            return NotFound("Produto não existe");
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            var productUpdated = _productHandler.Update(id, product);

            if (productUpdated) return Ok("Produto atualizado com sucesso");

            return BadRequest("Não foi possível atualizar o produto");
        }
    }
}
