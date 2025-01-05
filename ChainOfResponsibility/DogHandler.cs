namespace ChainOfResponsibility
{
    internal class DogHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if ((request as string) == "Racao")
            {
                return $"Cachorro: Eu irei comer a {request}.";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}