namespace ChainOfResponsibility
{
    // A interface Handler declara um método para construir a cadeia de
    // manipuladores. Ela também declara um método para executar uma solicitação.
    internal interface IHandler
    {
        IHandler Next(IHandler handler);

        object? Handle(object request);
    }
}