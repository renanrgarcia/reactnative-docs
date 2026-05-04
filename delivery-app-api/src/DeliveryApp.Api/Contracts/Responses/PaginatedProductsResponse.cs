namespace DeliveryApp.Api.Contracts.Responses;

public sealed record PaginatedProductsResponse(
    IReadOnlyList<ProductListItemResponse> Items,
    int Page,
    int PerPage,
    int TotalItems,
    int TotalPages);
