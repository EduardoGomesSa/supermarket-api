using Microsoft.AspNetCore.Mvc;
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
            var saved = 0;
            using (var context = new ApplicationContext())
            {
                context.Products.Add(product);

                saved = context.SaveChanges();
            }

            return Ok(saved);
        }
    }
}
