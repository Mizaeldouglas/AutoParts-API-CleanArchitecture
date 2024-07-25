using autoParts.Application.DTOs;
using autoParts.Application.Services;
using autoParts.Application.UseCases.Product;
using Microsoft.AspNetCore.Mvc;

namespace autoParts.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        
        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDto productDto)
        {
            var addProductUseCase = new AddProductUseCase(_productService);
            
            addProductUseCase.Execute(productDto);

            return Ok();
        }
        
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetProductById(long id)
        {
            var product = _productService.GetProductById(id);
            if (product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(long id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody] ProductDto productDto, long id)
        {
            _productService.UpdateProduct(productDto, id);
            return Ok();
        }
    }
}
