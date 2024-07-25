using autoParts.Application.DTOs;
using autoParts.Application.Interfaces;
using autoParts.Domain.Entities;
using autoParts.Domain.Interfaces;

namespace autoParts.Application.Services;

public class ProductService : IProductService
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
    
    public ProductDto GetProductById(long id)
    {
        var product = _productRepository.GetProductById(id);
        var productDto = new ProductDto
        {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price
        };
        
        return productDto;
    }
    
    public void DeleteProduct(long id)
    {
        _productRepository.DeleteProduct(id);
    }
    
    public void UpdateProduct(ProductDto productDto, long id)
    {
        var product = new Product
        {
            Id = id,
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price
        };
        
        _productRepository.UpdateProduct(product);
    }
    
}