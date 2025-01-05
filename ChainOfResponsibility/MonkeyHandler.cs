namespace ChainOfResponsibility
{
    internal class MonkeyHandler : AbstractHandler
    {
        public override object? Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Macaco: Eu irei comer a {request}.";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}