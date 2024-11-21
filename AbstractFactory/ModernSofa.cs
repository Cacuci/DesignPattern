namespace AbstractFactory
{
    // Produtos concretos são criados por fábricas concretas
    // correspondentes.
    internal class ModernSofa : ISofa
    {
        public void HasLegs() => Console.WriteLine("Modern Sofá com pernas");
    }
}