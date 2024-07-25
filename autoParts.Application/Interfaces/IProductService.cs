using autoParts.Application.DTOs;

namespace autoParts.Application.Interfaces;

public interface IProductService
{
    void AddProduct(ProductDto productDto);
    IEnumerable<ProductDto> GetAllProducts();
    ProductDto GetProductById(long id);
    void DeleteProduct(long id);
    void UpdateProduct(ProductDto productDto, long id);
}