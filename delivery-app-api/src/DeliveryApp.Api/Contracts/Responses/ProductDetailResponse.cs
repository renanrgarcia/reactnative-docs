namespace DeliveryApp.Api.Contracts.Responses;

public sealed record ProductDetailResponse(
    string Category,
    string Name,
    int Id,
    string Description,
    string Image);
