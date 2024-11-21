namespace AbstractFactory
{
    // A interface fábrica abstrata declara um conjunto de métodos
    // que retorna diferentes produtos abstratos. Estes produtos
    // estão relacionados por um tema ou conceito de alto nível (família).
    // Produtos de uma família são geralmente capazes de colaborar entre si.
    // Uma família de produtos pode ter várias variantes, mas os produtos de uma
    // variante são incompatíveis com os produtos de outro variante.
    internal abstract class AbstractFactory
    {
        public abstract IChair CreateChair();
        public abstract ISofa CreateSofa();
    }
}