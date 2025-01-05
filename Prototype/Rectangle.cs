namespace Prototype
{
    // Protótipo concreto. O método de clonagem cria um novo objeto
    // e passa ele ao construtor. Até o construtor terminar, ele tem
    // uma referência ao clone fresco. Portanto, ninguém tem acesso
    // ao clone parcialmente construído. Isso faz com que o clone
    // resultante seja consistente.
    internal class Rectangle : Shape
    {
        private decimal _width;
        private decimal _height;

        // Uma chamada para o construtor pai é necessária para
        // copiar campos privados definidos na classe pai.
        public Rectangle(decimal width, decimal height, decimal x, decimal y) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            _width = rectangle._width;
            _height = rectangle._height;
        }

        public void UpdateWidth(decimal width)
        {
            _width = width;
        }

        public new Rectangle Clone() => new(this);
    }
}