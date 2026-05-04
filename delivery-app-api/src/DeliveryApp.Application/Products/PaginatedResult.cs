namespace DeliveryApp.Application.Products;

public sealed record PaginatedResult<T>(
    IReadOnlyList<T> Items,
    int Page,
    int PerPage,
    int TotalItems,
    int TotalPages);
