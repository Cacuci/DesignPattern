namespace ChainOfResponsibility
{
    // O comportamento de encadeamento padrão pode ser implementado
    // dentro de uma classe manipuladora base.
    internal class AbstractHandler : IHandler
    {
        private IHandler? _next;

        public virtual object? Handle(object request)
        {
            if (this._next is not null)
            {
                return this._next.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler Next(IHandler handler)
        {
            _next = handler;

            return _next;
        }
    }
}