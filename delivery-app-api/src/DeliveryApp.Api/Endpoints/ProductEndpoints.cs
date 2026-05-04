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
                result.Items.Select(product => new ProductListItemResponse(
                    product.Id,
                    product.Name,
                    product.Description,
                    product.Price,
                    product.ImageUrl)).ToArray(),
                result.Page,
                result.PerPage,
                result.TotalItems,
                result.TotalPages);

            return Results.Ok(response);
        });

        app.MapGet("/products/{id:int}", (int id, ProductCatalog catalog) =>
        {
            var product = catalog.GetById(id);

            return product is null
                ? Results.NotFound()
                : Results.Ok(new ProductDetailResponse(
                    product.Id,
                    product.Name,
                    product.Description,
                    product.Price,
                    product.ImageUrl,
                    product.Ingredients.Select(ingredient => new IngredientResponse(ingredient)).ToArray()));
        });

        return app;
    }
}
