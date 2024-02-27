// See https://aka.ms/new-console-template for more information
using DB1;

Console.WriteLine("Hello, World!");

var dbContext = new PizzaContextFactory().CreateDbContext(null);
//dbContext.Sauces.Add(new Sauce { Name = "Paradicsom"});
//dbContext.SaveChanges();