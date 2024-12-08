namespace Proxy
{
    // O Proxy possui uma interface idêntica ao RealSubject.
    internal class Proxy : ISubject
    {
        private readonly ISubject _subject;

        public Proxy(ISubject subject) => _subject = subject;

        public void Request()
        {
            if (CheckAccess())
            {
                _subject.Request();

                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            //Algumas verificações reais devem ser feitas aqui.
            Console.WriteLine("Proxy: Verificando o acesso antes de disparar uma requisiçao.");

            return true;
        }

        public void LogAccess() => Console.WriteLine("Proxy: Registrando o horário da requisição.");
    }
}