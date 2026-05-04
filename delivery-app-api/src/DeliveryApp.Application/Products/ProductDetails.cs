namespace DeliveryApp.Application.Products;

public sealed record ProductDetails(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    IReadOnlyList<string> Ingredients);
