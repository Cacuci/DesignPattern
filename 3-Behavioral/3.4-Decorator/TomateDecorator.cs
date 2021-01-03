public class TomateDecorator : PizzaDecorator
{
    public TomateDecorator(IPizzaComponent iPizzaComponent) : base(iPizzaComponent)
    {
        Description = "Tomate";
    }

    public override double CalculateCost() => base.CalculateCost() + 0.25;

    public override string GetDescription() => $"{base.GetDescription()}, {Description}";
}