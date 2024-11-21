namespace FactoryMethod
{
    // Criadores concretos sobrescrevem o método de fábrica para alterar o
    // tipo do produto resultante.
    internal class ShipConcreteFactory : Factory
    {
        // Observe que a assinatura do método ainda utiliza o Transport abstrato
        // tipo, mesmo que o Transport concreto seja realmente retornado do
        // método. Desta forma, a Factory pode permanecer independente do Transport concreto classe.
        protected override ITransport FactoryMethod() => new Ship();
    }
}