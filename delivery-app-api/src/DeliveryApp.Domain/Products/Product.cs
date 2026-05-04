namespace DeliveryApp.Domain.Products;

public sealed record Product(
    int Id,
    string Category,
    string Name,
    string Description,
    string Image);
