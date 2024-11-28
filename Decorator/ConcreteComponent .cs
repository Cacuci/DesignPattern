namespace Decorator
{
    // Componentes concretos fornecem implementações padrão das operações.
    // Pode haver diversas variações dessas classes.
    internal class ConcreteComponent : IComponent
    {
        public string Operation() => "ConcreteComponent";
    }
}