namespace Prototype
{
    internal class Shape : IPrototype
    {
        private readonly decimal _x;
        private readonly decimal _y;

        public Shape(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        public Shape(Shape shape)
        {
            _x = shape._x;
            _y = shape._y;
        }

        public Shape Clone() => throw new NotImplementedException();
    }
}