namespace Prototype
{
    // Protótipo base.
    internal class Shape : IPrototype
    {
        private readonly decimal _x;
        private readonly decimal _y;

        public Shape(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        // O construtor do protótipo. Um objeto novo é inicializado
        // com valores do objeto existente.
        public Shape(Shape shape)
        {
            _x = shape._x;
            _y = shape._y;
        }

        // A operação de clonagem retorna uma das subclasses Shape.
        public Shape Clone() => throw new NotImplementedException();
    }
}