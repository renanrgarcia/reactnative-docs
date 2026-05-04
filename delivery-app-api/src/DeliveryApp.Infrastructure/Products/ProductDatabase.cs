using DeliveryApp.Domain.Products;

namespace DeliveryApp.Infrastructure.Products;

internal static class ProductDatabase
{
    public static IReadOnlyList<Product> Products { get; } =
    [
        new(
            1,
            "Classic Burger",
            "Grilled beef, cheddar, lettuce, tomato, and house sauce.",
            12.90m,
            "https://images.unsplash.com/photo-1568901346375-23c9450c58cd",
            ["Beef patty", "Cheddar", "Lettuce", "Tomato", "House sauce"]),
        new(
            2,
            "Margherita Pizza",
            "Stone-baked pizza with mozzarella, tomato, and basil.",
            18.50m,
            "https://images.unsplash.com/photo-1604382354936-07c5d9983bd3",
            ["Mozzarella", "Tomato sauce", "Basil", "Olive oil"]),
        new(
            3,
            "Chicken Bowl",
            "Roasted chicken with rice, greens, avocado, and lime dressing.",
            15.25m,
            "https://images.unsplash.com/photo-1546069901-ba9599a7e63c",
            ["Chicken", "Rice", "Avocado", "Mixed greens", "Lime dressing"]),
        new(
            4,
            "Sushi Combo",
            "Assorted salmon, tuna, and vegetable rolls with soy and ginger.",
            22.00m,
            "https://images.unsplash.com/photo-1579871494447-9811cf80d66c",
            ["Salmon", "Tuna", "Rice", "Nori", "Pickled ginger"]),
        new(
            5,
            "Pasta Alfredo",
            "Creamy fettuccine with parmesan and grilled chicken.",
            16.75m,
            "https://images.unsplash.com/photo-1645112411341-6c4fd023714a",
            ["Fettuccine", "Chicken", "Parmesan", "Cream", "Black pepper"]),
        new(
            6,
            "Veggie Wrap",
            "Warm tortilla with hummus, roasted vegetables, and greens.",
            10.50m,
            "https://images.unsplash.com/photo-1626700051175-6818013e1d4f",
            ["Tortilla", "Hummus", "Zucchini", "Peppers", "Spinach"])
    ];
}
