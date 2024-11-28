using Decorator;

Client client = new();

var simple = new ConcreteComponent();

Console.WriteLine("Client: eu recebo um componente simples:");
client.ClientCode(simple);
Console.WriteLine();

// ...assim como os decorators.
//
// Observe como os decorators podem agrupar não apenas componentes simples, mas também os
// outros decorators.
ConcreteDecoratorA decoratorA = new(simple);
ConcreteDecoratorB decoratorB = new(decoratorA);
Console.WriteLine("client: Agora eu recebo um compondente Decorado");
client.ClientCode(decoratorB);