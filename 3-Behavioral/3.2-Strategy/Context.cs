
public class Context
{
    private readonly IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ConcretInterface()
    {
        _strategy.AlgorithmInterface();
    }
}