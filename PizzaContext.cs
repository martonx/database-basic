using Microsoft.EntityFrameworkCore;

namespace DB1;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
    : base(options)
    {
    }

    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Sauce> Sauces { get; set; }
}