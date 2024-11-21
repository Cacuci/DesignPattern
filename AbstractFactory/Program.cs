using AbstractFactory;

var modern = new ModernConcreteFactory();

Application(modern);

var victorian = new VictorianConcreteFactory();

Application(victorian);

Console.ReadKey();

// O código cliente trabalha com fábricas e produtos apenas
// através de tipos abstratos: AbstractFactory, IChair e ISofa.
// Isso permite que você passe qualquer subclasse fábrica ou de
// produto para o código cliente sem quebrá-lo.
static void Application(AbstractFactory.AbstractFactory factory)
{
    var chair = factory.CreateChair();
    var sofa = factory.CreateSofa();

    chair.SitOn();

    sofa.HasLegs();
}