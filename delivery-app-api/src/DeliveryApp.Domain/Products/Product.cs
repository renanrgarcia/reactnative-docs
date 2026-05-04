namespace DeliveryApp.Domain.Products;

public sealed record Product(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    IReadOnlyList<string> Ingredients);
