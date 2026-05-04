using DeliveryApp.Application.Products;
using DeliveryApp.Domain.Products;

namespace DeliveryApp.Infrastructure.Products;

public sealed class InMemoryProductRepository : IProductRepository
{
    public IReadOnlyList<Product> List() => ProductDatabase.Products;

    public Product? GetById(int id) => ProductDatabase.Products.FirstOrDefault(product => product.Id == id);
}
