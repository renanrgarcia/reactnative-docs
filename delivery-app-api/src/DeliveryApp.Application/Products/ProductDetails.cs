namespace DeliveryApp.Application.Products;

public sealed record ProductDetails(
    int Id,
    string Category,
    string Name,
    string Description,
    string Image);
