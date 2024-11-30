namespace Decorator
{
    // Decorators concretos chamam o objeto envolvido e alteram seu resultado de alguma forma.
    internal class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component) { }

        public override string Operation() => $"{nameof(ConcreteDecoratorA)}({base.Operation()})";
    }
}