namespace FlyWeight
{
    // O objeto contextual contém a parte extrínseca (Mutável) do estado da
    // árvore. Uma aplicação pode criar bilhões desses estados, já
    // que são muito pequenos:
    // apenas dois números inteiros para coordenadas e um campo de
    // referência.
    internal class Tree
    {
        private readonly decimal _x;
        private readonly decimal _y;
        private readonly TreeType _treeType;

        public Tree(decimal x, decimal y, TreeType treeType)
        {
            _x = x;
            _y = y;
            _treeType = treeType;
        }

        public void Draw() => _treeType.Draw(_x, _y);
    }
}