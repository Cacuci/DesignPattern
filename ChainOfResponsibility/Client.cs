namespace ChainOfResponsibility
{
    internal class Client
    {
        // O código do cliente geralmente é adequado para trabalhar com um único manipulador. Na
        // maioria dos casos, ele nem mesmo sabe que o manipulador faz parte de uma cadeia.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var item in new List<string> { "Banana", "Racao", "Castanha", "Pão" })
            {
                Console.WriteLine($"Client: Quem quer uma {item}");

                var result = handler.Handle(item);

                if (result is not null)
                {
                    Console.WriteLine($" {result}");
                }
                else
                {
                    Console.WriteLine($" {item} foi deixado intocado");
                }
            }
        }
    }
}