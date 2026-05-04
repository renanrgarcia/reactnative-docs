using DeliveryApp.Domain.Products;

namespace DeliveryApp.Application.Products;

public interface IProductRepository
{
    IReadOnlyList<Product> List();

    Product? GetById(int id);
}
