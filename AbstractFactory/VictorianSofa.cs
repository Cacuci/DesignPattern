namespace AbstractFactory
{
    // Produtos concretos são criados por fábricas concretas
    // correspondentes.
    internal class VictorianSofa : ISofa
    {
        public void HasLegs() => Console.WriteLine("Victorian Sofá com pernas");
    }
}
