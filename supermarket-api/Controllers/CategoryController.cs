﻿using Microsoft.AspNetCore.Mvc;
using supermarket.application.Handlers;
using supermarket.application.Interfaces;
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

            return Ok("Não tem nenhuma categoria cadastrada");
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var category = _categoryHandler.GetById(id);

            if (category != null) return Ok(category);

            return Ok("categoria não existe");
        }

        [HttpPut]
        public IActionResult Put([FromHeader]int id, [FromBody] Category category)
        {
            var categoryUpdeted = _categoryHandler.Update(id, category);

            if(categoryUpdeted) return Ok("Category updeted with sucess");

            return BadRequest("Category don´t updated");
        }
    }
}
