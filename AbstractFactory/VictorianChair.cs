namespace AbstractFactory
{
    // Produtos concretos são criados por fábricas concretas
    // correspondentes.
    internal class VictorianChair : IChair
    {
        public void SitOn() => Console.WriteLine("Victorian Cadeira para sentar");
    }
}