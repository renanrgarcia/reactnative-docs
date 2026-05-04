using DeliveryApp.Domain.Products;

namespace DeliveryApp.Infrastructure.Products;

internal static class ProductDatabase
{
    public static IReadOnlyList<Product> Products { get; } =
    [
        new(
            1,
            "Lanches",
            "React Burger",
            "Um burger declarativo com queijo derretido, bacon crocante e molho da casa.",
            "http://localhost:3001/images/react-burger.png"),
        new(
            2,
            "Lanches",
            "Angular Rings",
            "Aneis de cebola crocantes com uma arquitetura robusta de sabor.",
            "http://localhost:3001/images/angular-rings.png"),
        new(
            3,
            "Bebidas",
            "Java Juice",
            "Suco natural forte e confiavel para manter sua rotina em execucao.",
            "http://localhost:3001/images/java-juice.png"),
        new(
            4,
            "Sobremesas",
            "Python Pie",
            "Uma torta simples, flexivel e perfeita para finalizar qualquer pedido.",
            "http://localhost:3001/images/python-pie.png"),
        new(
            5,
            "Acompanhamentos",
            "CSS Chips",
            "Batatas onduladas com camadas de tempero e finalizacao impecavel.",
            "http://localhost:3001/images/css-chips.png"),
        new(
            6,
            "Lanches",
            "HTML Hot Dog",
            "Um classico bem estruturado com salsicha, molho e batata palha.",
            "http://localhost:3001/images/html-hotdog.png"),
        new(
            7,
            "Bebidas",
            "TypeScript Tea",
            "Cha gelado tipado na medida certa, refrescante e previsivel.",
            "http://localhost:3001/images/typescript-tea.png"),
        new(
            8,
            "Sobremesas",
            "Node Nutella",
            "Crepe doce rapido, leve e pronto para compartilhar.",
            "http://localhost:3001/images/node-nutella.png"),
        new(
            9,
            "Acompanhamentos",
            "Docker Fries",
            "Porcao de fritas containerizada para chegar quente e crocante.",
            "http://localhost:3001/images/docker-fries.png"),
        new(
            10,
            "Lanches",
            "Ruby Roll",
            "Wrap artesanal com recheio brilhante, cremoso e bem temperado.",
            "http://localhost:3001/images/ruby-roll.png"),
        new(
            13,
            "Acompanhamentos",
            "Kernel Kibe",
            "A base do nosso sistema de porções. Deliciosos quibes recheados com queijo, servidos com limão.",
            "http://localhost:3001/images/kibi.png"),
        new(
            15,
            "Lanches",
            "Vue.js-teca",
            "Um lanche progressivo e delicioso, que vai te conquistando aos poucos com sua simplicidade e sabor.",
            "http://localhost:3001/images/170785489065cbcc2ab2911.jpeg"),
        new(
            17,
            "Bebidas",
            "Swift Shake",
            "Um milkshake rápido e delicioso, perfeito para o seu sistema operacional de sabores.",
            "http://localhost:3001/images/milkshake.png"),
        new(
            18,
            "Bebidas",
            "Kotlin Coffee",
            "Um café gelado moderno e interoperável com sua vontade de cafeína.",
            "http://localhost:3001/images/cafe.png"),
        new(
            19,
            "Sobremesas",
            "Git Gateau",
            "Petit gateau com sorvete para versionar bons momentos a cada colherada.",
            "http://localhost:3001/images/gateau.png"),
        new(
            20,
            "Acompanhamentos",
            "Spring Salad",
            "Salada leve com folhas frescas, tomate, cenoura e molho especial.",
            "http://localhost:3001/images/salada.png")
    ];
}
