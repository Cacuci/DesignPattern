namespace Decorator
{
    // Decorators podem executar seu comportamento antes ou depois da chamada para
    // um objeto empacotado.
    internal class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override string Operation() => $"{nameof(ConcreteDecoratorB)}({base.Operation()})";
    }
}