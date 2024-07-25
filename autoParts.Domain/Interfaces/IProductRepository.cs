using autoParts.Domain.Entities;

namespace autoParts.Domain.Interfaces;

public interface IProductRepository
{
    void AddProduct(Product product);
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(long id);
    void DeleteProduct(long id);
    void UpdateProduct(Product product);
    }