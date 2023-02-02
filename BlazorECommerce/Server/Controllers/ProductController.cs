using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> Products = new()
        {
            new Product
            {
                Id = 1,
                Title = "Product 1",
                Description = "This is the product 1",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fc/Flag_of_Mexico.svg",
                Price = 10.0m
            },
            new Product
            {
                Id = 2,
                Title = "Product 2",
                Description = "This is the product 2",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%2C_2020%E2%80%93present%29.svg",
                Price = 20.0m
            },
            new Product
            {
                Id = 3,
                Title = "Product 3",
                Description = "This is the product 3",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/20/Flag_of_the_Netherlands.svg",
                Price = 30.0m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //var result = await _productService.GetProductsAsync();
            return Ok(Products);
        }
    }
}
