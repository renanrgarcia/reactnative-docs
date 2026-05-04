namespace DeliveryApp.Api.Contracts.Responses;

public sealed record ProductDetailResponse(
    int Id,
    string Name,
    string Description,
    decimal Price,
    string ImageUrl,
    IReadOnlyList<IngredientResponse> Ingredients);
