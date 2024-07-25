using autoParts.Application.DTOs;
using autoParts.Application.Services;

namespace autoParts.Application.UseCases.Product;

public class AddProductUseCase(ProductService productService)
{
    public void Execute(ProductDto productDto)
    {
        productService.AddProduct(productDto);
    }
}