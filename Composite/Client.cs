namespace Composite
{
    internal class Client
    {
        // O código cliente funciona com todos os componentes através da base
        //interface.
        public void ClientCode(Componet leaf) => Console.WriteLine($"Resultado: {leaf.Operation()}\n");

        // Graças ao fato das operações de gerenciamento serem declaradas
        // na classe base Component, o código do cliente pode funcionar com qualquer
        // componente, simples ou complexo, sem depender da sua classe concreta.
        public void ClientCode(Componet componet, Componet leaf)
        {
            if (leaf.IsComposite())
            {
                componet.Add(leaf);
            }

            Console.WriteLine($"Resultado: {componet.Operation()}");
        }
    }
}