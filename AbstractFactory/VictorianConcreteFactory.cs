namespace AbstractFactory
{
    // As fábricas concretas produzem uma família de produtos que
    // pertencem a uma única variante. A fábrica garante que os
    // produtos resultantes sejam compatíveis. Assinaturas dos
    // métodos fabrica retornam um produto abstrato, enquanto que
    // dentro do método um produto concreto é instanciado.

    // Cada fábrica concreta tem uma variante de produto
    // correspondente.
    internal class VictorianConcreteFactory : AbstractFactory
    {
        public override IChair CreateChair() => new VictorianChair();

        public override ISofa CreateSofa() => new VictorianSofa();
    }
}