
public class Adapter : Target
{
    private readonly Adaptee _adaptee = new Adaptee();

    public override void Requests()
    {
        _adaptee.SpecificRequest();
    }
}