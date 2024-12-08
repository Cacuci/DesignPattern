namespace Proxy
{
    // O RealSubject contém alguma lógica de negócios central. Normalmente, RealSubjects
    // são capazes de realizar algum trabalho útil que também pode ser muito lento ou
    // sensível - por exemplo. corrigindo dados de entrada. Um proxy pode resolver esses problemas
    // sem nenhuma alteração no código do RealSubject.
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Manipulando Requisição.");
        }
    }
}