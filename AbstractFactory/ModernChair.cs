namespace AbstractFactory
{
    // Produtos concretos são criados por fábricas concretas
    // correspondentes.
    internal class ModernChair : IChair
    {
        public void SitOn() => Console.WriteLine("Modern Cadeira para sentar");
    }
}