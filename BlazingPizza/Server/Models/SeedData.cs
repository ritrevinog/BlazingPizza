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
                    Name = "Hawaiana",
                    Description = "De piña, jamón y queso",
                    BasePrice = 190.25m,
                    ImageUrl = "images/pizzas/hawaiian.jpg"
                }
            };

            context.Specials.AddRange(Specials);
            context.SaveChanges();
        }
    }
}
