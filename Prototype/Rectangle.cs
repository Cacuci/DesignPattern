namespace Prototype
{
    internal class Rectangle : Shape
    {
        private decimal _width;
        private decimal _height;

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

        public new Shape Clone() => new Rectangle(this);
    }
}