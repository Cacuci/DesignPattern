namespace Proxy
{
    internal class Client
    {
        // O código do cliente deve funcionar com todos os objetos (tanto Subject
        // e proxies) através da interface Subject para suportar ambos
        // Subject e proxies. Na vida real, porém, os clientes trabalham principalmente com
        // seus Subject reais diretamente. Neste caso, para implementar o padrão
        // mais facilmente, você pode estender seu proxy da classe do sujeito real.
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}