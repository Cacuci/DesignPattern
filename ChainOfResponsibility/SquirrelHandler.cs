namespace ChainOfResponsibility
{
    internal class SquirrelHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if ((request as string) == "Castanha")
            {
                return $"Esquilo: Eu irei comer a {request}.";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}