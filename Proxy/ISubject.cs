namespace Proxy
{
    // A interface Subject declara operações comuns para RealSubject e
    // o proxy. Contanto que o cliente trabalhe com RealSubject usando este
    // interface, você poderá passar um proxy em vez de um assunto real.
    internal interface ISubject
    {
        void Request();
    }
}