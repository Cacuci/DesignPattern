namespace FactoryMethod
{
    // Transport concreto fornecem diversas implementações do Transport interface.
    internal class Truck : ITransport
    {
        public string Deliver() => "Truck";
    }
}
