namespace DB1;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Sauce Sauce { get; } = new();
    public List<Topping> Toppings { get; } = new();
}
