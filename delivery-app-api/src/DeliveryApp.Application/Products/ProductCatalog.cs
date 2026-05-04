namespace DeliveryApp.Application.Products;

public sealed class ProductCatalog(IProductRepository repository)
{
    public PaginatedResult<ProductSummary> List(PaginationOptions pagination)
    {
        var products = repository.List();
        var page = pagination.NormalizedPage;
        var perPage = pagination.NormalizedPerPage;
        var totalPages = (int)Math.Ceiling(products.Count / (double)perPage);
        var items = products
            .Skip((page - 1) * perPage)
            .Take(perPage)
            .Select(product => new ProductSummary(
                product.Id,
                product.Category,
                product.Name,
                product.Description,
                product.Image))
            .ToArray();

        return new PaginatedResult<ProductSummary>(items, page, perPage, products.Count, totalPages);
    }

    public ProductDetails? GetById(int id)
    {
        var product = repository.GetById(id);

        return product is null
            ? null
            : new ProductDetails(
                product.Id,
                product.Category,
                product.Name,
                product.Description,
                product.Image);
    }
}
