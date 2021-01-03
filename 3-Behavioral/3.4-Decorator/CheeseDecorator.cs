public class CheeseDecorator: PizzaDecorator
{
    public CheeseDecorator(IPizzaComponent iPizzaComponent) : base(iPizzaComponent)
    {
        Description = "Cheese";
    }

    public override double CalculateCost() => base.CalculateCost() + 1.25;

    public override string GetDescription() => $"{base.GetDescription()}, {Description}";
}