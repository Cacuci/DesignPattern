public interface IPizzaComponent
{
    public string Description { get; set; }
    public abstract string GetDescription();
    public abstract double CalculateCost();
}