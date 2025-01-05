using ChainOfResponsibility;

// A outra parte do código do cliente constrói a cadeia real.
var monkey = new MonkeyHandler();
var dog = new DogHandler();
var squirrel = new SquirrelHandler();

monkey.Next(dog)
      .Next(squirrel);

// O cliente deve ser capaz de enviar uma solicitação para qualquer manipulador, não
// apenas o primeiro na cadeia.
Console.WriteLine("Chain: Monkey > Dog > Squirrel\n");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Dog > Squirrel\n");
Client.ClientCode(dog);