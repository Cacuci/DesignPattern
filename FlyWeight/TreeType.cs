namespace FlyWeight
{
    // A classe flyweight contém uma parte do estado de uma árvore.
    // Esses campos armazenam valores que são únicos para cada
    // árvore em particular. Por exemplo, você não vai encontrar
    // coordenadas da árvore aqui. Já que esses dados geralmente são
    // GRANDES, você gastaria muita memória mantendo-os em cada
    // objeto árvore. Ao invés disso, nós podemos extrair a textura,
    // cor e outros dados repetitivos em um objeto separado os quais
    // muitas árvores individuais podem referenciar.
    internal class TreeType
    {
        private readonly string _name;
        private readonly string _color;
        private readonly string _texture;

        public TreeType(string name, string color, string texture)
        {
            _name = name;
            _color = color;
            _texture = texture;
        }

        public TreeType? Find(string name, string color, string texture)
        {
            TreeType? result = null;

            if (_name == name && _color == color && _texture == texture)
            {
                result = this;
            }

            return result;
        }

        public void Draw(decimal x, decimal y) => Console.WriteLine($"Cordenada X {x} e Y {y}. Para {_name} {_color} {_texture}");
    }
}