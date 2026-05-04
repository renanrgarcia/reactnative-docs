namespace DeliveryApp.Application.Products;

public sealed record ProductSummary(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl);
