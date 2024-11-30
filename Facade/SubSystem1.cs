namespace Facade
{
    // O subsistema pode aceitar solicitações da fachada ou do cliente
    // diretamente. De qualquer forma, para o Subsistema, a Fachada é mais uma
    // cliente, e não faz parte do Subsistema.
    internal class SubSystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}