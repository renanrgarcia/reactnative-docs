namespace DeliveryApp.Api.Contracts.Responses;

public sealed record PaginatedProductsResponse(
    int Page,
    int PerPage,
    int TotalItems,
    int TotalPages,
    IReadOnlyList<ProductListItemResponse> Items);
