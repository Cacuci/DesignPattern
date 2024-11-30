namespace Facade
{
    // A classe Facade fornece uma interface simples para a lógica complexa de um
    // ou vários subsistemas. O Facade delega as solicitações do cliente ao
    // objetos apropriados dentro do subsistema. A Fachada também é responsável
    // para gerenciar seu ciclo de vida. Tudo isso protege o cliente da
    // complexidade indesejada do subsistema.
    internal class Facade
    {
        private readonly SubSystem1 _subSystem1;
        private readonly SubSystem2 _subSystem2;

        public Facade(SubSystem1 subSystem1, SubSystem2 subSystem2)
        {
            _subSystem1 = subSystem1;
            _subSystem2 = subSystem2;
        }


        // Os métodos do Facade são atalhos convenientes para o sofisticado
        // funcionalidade dos subsistemas. No entanto, os clientes chegam apenas a um
        // fração das capacidades de um subsistema.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += _subSystem1.Operation1();
            result += _subSystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += _subSystem1.OperationN();
            result += _subSystem2.OperationZ();
            return result;
        }
    }
}