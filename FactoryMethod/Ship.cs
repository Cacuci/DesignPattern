namespace FactoryMethod
{
    // Transport concreto fornecem diversas implementações do Transport interface.
    internal class Ship : ITransport
    {
        public string Deliver() => "Ship";
    }
}
