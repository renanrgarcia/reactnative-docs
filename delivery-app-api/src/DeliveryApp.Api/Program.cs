using DeliveryApp.Api.Endpoints;
using DeliveryApp.Application.Products;
using DeliveryApp.Infrastructure.Products;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>();
builder.Services.AddSingleton<ProductCatalog>();

var app = builder.Build();

app.UseCors();

app.MapProductEndpoints();

app.MapGet("/", () => Results.Ok(new
{
    name = "Delivery App API",
    endpoints = new[]
    {
        "POST /products/paginated",
        "GET /products/{id}"
    }
}));

app.Run();
