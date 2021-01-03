public class PizzaDecorator : IPizzaComponent
{
    public PizzaDecorator(IPizzaComponent iPizzaComponent)
    {
        _IPizzaComponent = iPizzaComponent;
        Description = _IPizzaComponent.Description;
    }

    private readonly IPizzaComponent _IPizzaComponent;

    public string Description { get; set; }

    public virtual double CalculateCost() => _IPizzaComponent.CalculateCost();

    public virtual string GetDescription() => _IPizzaComponent.GetDescription();
}
