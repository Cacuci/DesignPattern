namespace Decorator
{
    internal abstract class Decorator : IComponent
    {
        protected IComponent _component;

        protected Decorator(IComponent component) => _component = component;

        // O Decorator delega todo o trabalho ao componente encapsulado.
        public virtual string Operation() => _component != null ? _component.Operation() : string.Empty;
    }
}