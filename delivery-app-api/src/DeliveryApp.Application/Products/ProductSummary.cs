namespace DeliveryApp.Application.Products;

public sealed record ProductSummary(
    int Id,
    string Category,
    string Name,
    string Description,
    string Image);
