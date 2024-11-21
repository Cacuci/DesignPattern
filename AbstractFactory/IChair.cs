namespace AbstractFactory
{
    // Aqui está a interface base um produto. Todos os
    // produtos podem interagir entre si, mas a interação apropriada
    // só é possível entre produtos da mesma variante concreta.

    // Cada produto distinto de uma família de produtos deve ter uma
    // interface base. Todas as variantes do produto devem
    // implementar essa interface.
    internal interface IChair
    {
        void SitOn();
    }
}