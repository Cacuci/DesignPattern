using System.Data;

namespace Singleton
{
    // A classe Singleton define o método 'Instance' que permite
    // clientes acessar a mesma instância de um DataTable.
    internal class Singleton
    {
        // O campo para armazenar a instância singleton deve ser
        // declarado como estático
        private static readonly DataTable instance = new();

        // O construtor do singleton devem sempre ser privado para
        // prevenir chamadas diretas de construção com o operador
        // `new`.
        private Singleton() { }

        // O método estático que controla acesso à instância do
        // singleton
        public static DataTable Instance()
        {
            return instance;
        }
    }
}
