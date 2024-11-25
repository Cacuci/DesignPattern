namespace FactoryMethod
{
    // Criadores concretos sobrescrevem o método de fábrica para alterar o
    // tipo do transporte resultante.
    internal class TruckConcreteFactory : Factory
    {
        // Observe que a assinatura do método ainda utiliza o tipo Transport abstrato,
        // mesmo que o Transport concreto seja realmente retornado do
        // método. Desta forma, a Factory pode permanecer independente do Transport concreto classe.
        protected override ITransport FactoryMethod() => new Truck();

        // Observe que o método foi sobreescrito, alterando o comportamento padrão definido na Factory
        public override string Operation()
        {
            var transport = FactoryMethod();

            var result = "Alterado o comportamento com " + transport.Deliver();

            return result;
        }
    }
}