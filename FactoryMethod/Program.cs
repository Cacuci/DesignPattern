using FactoryMethod;

var ship = new ShipConcreteFactory();

Application(ship);

var truck = new TruckConcreteFactory();

Application(truck);

Console.ReadKey();

// O código cliente funciona com uma instância de um Factory concreto, nesse caso ShipFactory e TruckFactory,
// embora através de sua interface base. Enquanto o cliente continuar trabalhando com
// o criador através da interface base, você pode passá-lo para qualquer criador subclasse.
static void Application(Factory factory)
{
    Console.WriteLine(factory.Operation());
}