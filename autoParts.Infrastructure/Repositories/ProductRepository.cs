using autoParts.Domain.Entities;
using autoParts.Domain.Interfaces;
using autoParts.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace autoParts.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AutoPartsContext _context;

    public ProductRepository(AutoPartsContext context)
    {
        _context = context;
    }

    public void AddProduct(Product product)
    {
        _context.Set<Product>().Add(product);
        _context.SaveChanges();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        var products = _context.Set<Product>().ToList();
        return products;
    }

    public Product GetProductById(long id)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(long id)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}