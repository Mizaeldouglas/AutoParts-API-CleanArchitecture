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
        var product = _context.Set<Product>().Find(id);
        
        return product;
    }

    public void DeleteProduct(long id)
    {
        var product = _context.Set<Product>().Find(id);
        _context.Set<Product>().Remove(product);
        _context.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        var productToUpdate = _context.Set<Product>().Find(product.Id);
        if (productToUpdate == null)
        {
            // Handle the case where the product is not found. 
            // For example, you could throw a custom exception or return without doing anything.
            throw new KeyNotFoundException($"Product with ID {product.Id} not found.");
        }
        else
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            _context.SaveChanges();
        }
    }
}