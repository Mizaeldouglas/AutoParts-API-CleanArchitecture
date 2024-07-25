using autoParts.Application.DTOs;
using autoParts.Domain.Entities;
using autoParts.Domain.Interfaces;

namespace autoParts.Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    
    public void AddProduct(ProductDto productDto)
    {
        var product = new Product
        {
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price
        };
        
        _productRepository.AddProduct(product);
    }
    
    public IEnumerable<ProductDto> GetAllProducts()
    {
        var products = _productRepository.GetAllProducts();
        var productsDto = products.Select(p => new ProductDto
        {
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        });
        
        return productsDto;
    }
}