namespace FlyWeight
{
    // As classes Tree (Árvore) e Forest (Floresta) são os clientes
    // flyweight (TreeType). Você pode uni-las se não planeja desenvolver mais
    // a classe Tree.
    internal class Forest
    {
        private readonly List<Tree> _tress = [];

        public IReadOnlyCollection<Tree> Tress => _tress;

        public void PlantTree(decimal x, decimal y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);

            var tree = new Tree(x, y, type);

            _tress.Add(tree);
        }

        public void Draw()
        {
            foreach (var item in Tress)
            {
                item.Draw();
            }
        }
    }
}