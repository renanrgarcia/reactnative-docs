namespace DeliveryApp.Application.Products;

public sealed record PaginationOptions(int Page, int PerPage)
{
    public int NormalizedPage => Math.Max(1, Page);

    public int NormalizedPerPage => Math.Clamp(PerPage, 1, 50);
}
