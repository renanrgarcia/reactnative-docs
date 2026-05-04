using DeliveryApp.Api.Contracts.Requests;
using DeliveryApp.Api.Contracts.Responses;
using DeliveryApp.Application.Products;

namespace DeliveryApp.Api.Endpoints;

public static class ProductEndpoints
{
    public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/products/paginated", (PaginationRequest request, ProductCatalog catalog) =>
        {
            var result = catalog.List(new PaginationOptions(request.Page, request.PerPage));
            var response = new PaginatedProductsResponse(
                result.Page,
                result.PerPage,
                result.TotalItems,
                result.TotalPages,
                result.Items.Select(product => new ProductListItemResponse(
                    product.Category,
                    product.Name,
                    product.Id,
                    product.Description,
                    product.Image)).ToArray());

            return Results.Ok(response);
        });

        app.MapGet("/products/{id:int}", (int id, ProductCatalog catalog) =>
        {
            var product = catalog.GetById(id);

            return product is null
                ? Results.NotFound()
                : Results.Ok(new ProductDetailResponse(
                    product.Category,
                    product.Name,
                    product.Id,
                    product.Description,
                    product.Image));
        });

        return app;
    }
}
