namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // O método Instance sempre retornará a mesma instacia do objeto              
            var instance = Singleton.Instance();

            // O método Instance sempre retornará a mesma instacia do objeto              
            var instance2 = Singleton.Instance();

            // Aqui é possivel pereceber que objetos são identicos, ou seja, a instancia é a mesma              
            Console.WriteLine(instance.Equals(instance2));

            Console.ReadKey();
        }
    }
}