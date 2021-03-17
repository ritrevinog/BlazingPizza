using BlazingPizza.Shared;

namespace BlazingPizza.Server.Models
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext context)
        {
            var Specials = new PizzaSpecial[]
            {
                new PizzaSpecial
                {
                    Name = "Pizza clásica de queso",
                    Description = "Es de queso y delicioso",
                    BasePrice = 189.99m,
                    ImageUrl = "images/pizzas/cheese.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Tocinator",
                    Description = "Tiene TODO tipo de tocino",
                    BasePrice = 227.99m,
                    ImageUrl = "images/pizzas/bacon.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Clásica de pepperoni",
                    Description = "Es la pizza con la que cresiste, pero ardientemente deliciosa!",
                    BasePrice = 199.50m,
                    ImageUrl = "images/pizzas/pepperoni.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Pollo búfalo",
                    Description = "Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor",
                    BasePrice = 288.75m,
                    ImageUrl = "images/pizzas/meaty.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Amantes del champiñón",
                    Description = "Tiene champiñones. No es obvio?",
                    BasePrice = 209.00m,
                    ImageUrl = "images/pizzas/mushroom.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Hawaiana",
                    Description = "De piña, jamón y queso...",
                    BasePrice = 190.25m,
                    ImageUrl = "images/pizzas/hawaiian.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Delicia vegetariana",
                    Description = "Es como una ensalada, pero en una pizza",
                    BasePrice = 218.50m,
                    ImageUrl = "images/pizzas/salad.jpg"
                },
                new PizzaSpecial
                {
                    Name = "Margarita",
                    Description = "Pizza italiana tradicional con tomates y albahaca",
                    BasePrice = 189.99m,
                    ImageUrl = "images/pizzas/margherita.jpg"
                }
            };

            var Toppings = new Topping[]
            {
                new Topping { Name = "Queso extra", Price = 47.50m },
                new Topping { Name = "Tocino de pavo", Price = 56.80m },
                new Topping { Name = "Salchicha de pato", Price = 60.80m },
                new Topping { Name = "Albondigas de venado", Price = 47.50m },
                new Topping { Name = "Cubierta de langosta", Price = 1220.50m },
                new Topping { Name = "Caviar de esturion", Price = 1447.50m },
                new Topping { Name = "Pimiento", Price = 19.00m },
                new Topping { Name = "Cebolla", Price = 19.00m },
                new Topping { Name = "Champiñones", Price = 19.00m },
                new Topping { Name = "Bollos recien horneados", Price = 85.50m },
                new Topping { Name = "Queso cheddar", Price = 20.50m }
            };

            context.Toppings.AddRange(Toppings);
            context.Specials.AddRange(Specials);
            context.SaveChanges();
        }
    }
}
