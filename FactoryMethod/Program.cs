using FactoryMethod;

// O código cliente funciona com uma instância de um Factory concreto, nesse caso ShipFactory e TruckFactory,
// embora através de sua interface base. Enquanto o cliente continuar trabalhando com
// o criador através da interface base, você pode passá-lo para qualquer criador subclasse.

var ship = new ShipFactory();

Console.WriteLine(ship.Operation());

var truck = new TruckFactory();

Console.WriteLine(truck.Operation());

Console.ReadKey();