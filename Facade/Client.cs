namespace Facade
{
    // O código cliente trabalha com subsistemas complexos através de um simples
    // interface fornecida pelo Facade. Quando uma fachada gerencia o ciclo de vida
    // do subsistema, o cliente pode nem saber da existência
    // do subsistema. Essa abordagem permite manter a complexidade sob
    // controle.
    internal class Client
    {
        public static void ClientCode(Facade facade) => Console.WriteLine(facade.Operation());
    }
}