using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DB1;

public class PizzaContextFactory : IDesignTimeDbContextFactory<PizzaContext>
{
    public PizzaContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PizzaContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=true");

        return new PizzaContext(optionsBuilder.Options);
    }
}
