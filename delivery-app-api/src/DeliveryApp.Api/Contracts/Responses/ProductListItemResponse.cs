namespace DeliveryApp.Api.Contracts.Responses;

public sealed record ProductListItemResponse(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl);
