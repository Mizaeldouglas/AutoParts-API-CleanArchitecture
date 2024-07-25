// namespace autoParts.Infrastructure;
//
// // autoParts.Domain/Entities/Product.cs
// namespace autoParts.Domain.Entities
// {
//     public class Product
//     {
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Description { get; set; }
//         public decimal Price { get; set; }
//     }
// }
//
// // autoParts.Domain/Interfaces/IProductRepository.cs
// namespace autoParts.Domain.Interfaces
// {
//     public interface IProductRepository
//     {
//         void AddProduct(Product product);
//         // Outros métodos conforme necessário
//     }
// }
//
// // autoParts.Application/DTOs/ProductDto.cs
// namespace autoParts.Application.DTOs
// {
//     public class ProductDto
//     {
//         public string Name { get; set; }
//         public string Description { get; set; }
//         public decimal Price { get; set; }
//     }
// }
//
// // autoParts.Application/Services/ProductService.cs
// namespace autoParts.Application.Services
// {
//     public class ProductService
//     {
//         private readonly IProductRepository _productRepository;
//
//         public ProductService(IProductRepository productRepository)
//         {
//             _productRepository = productRepository;
//         }
//
//         public void AddProduct(ProductDto productDto)
//         {
//             var product = new Product
//             {
//                 Name = productDto.Name,
//                 Description = productDto.Description,
//                 Price = productDto.Price
//             };
//
//             _productRepository.AddProduct(product);
//         }
//     }
// }
//
// // autoParts.Infrastructure/Repositories/ProductRepository.cs
// namespace autoParts.Infrastructure.Repositories
// {
//     public class ProductRepository : IProductRepository
//     {
//         private readonly DbContext _context;
//
//         public ProductRepository(DbContext context)
//         {
//             _context = context;
//         }
//
//         public void AddProduct(Product product)
//         {
//             _context.Products.Add(product);
//             _context.SaveChanges();
//         }
//     }
// }
//
// // autoParts.API/Controllers/ProductController.cs
// namespace autoParts.API.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class ProductController : ControllerBase
//     {
//         private readonly ProductService _productService;
//
//         public ProductController(ProductService productService)
//         {
//             _productService = productService;
//         }
//
//         [HttpPost]
//         public IActionResult AddProduct([FromBody] ProductDto productDto)
//         {
//             _productService.AddProduct(productDto);
//             return Ok();
//         }
//     }
// }
