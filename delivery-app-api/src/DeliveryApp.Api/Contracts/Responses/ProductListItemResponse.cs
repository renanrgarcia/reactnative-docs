namespace DeliveryApp.Api.Contracts.Responses;

public sealed record ProductListItemResponse(
    string Category,
    string Name,
    int Id,
    string Description,
    string Image);
