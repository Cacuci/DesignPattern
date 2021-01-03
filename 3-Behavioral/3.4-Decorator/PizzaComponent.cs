public class PizzaComponent : IPizzaComponent
{
    public PizzaComponent()
    {
        Description = "PizzaComponent";
    }

    public string Description { get; set; }

    public double CalculateCost() => 45.0;

    public string GetDescription() => Description;
}