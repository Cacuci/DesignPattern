namespace FlyWeight
{
    // A fábrica flyweight decide se reutiliza o flyweight existente
    // ou cria um novo objeto.
    internal class TreeFactory
    {
        //Lista da classe flyweight
        private static readonly List<TreeType> _treeTypes = [];

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            TreeType? result = _treeTypes.FirstOrDefault(item => item.Find(name, color, texture) is not null);

            if (result == null)
            {
                result = new TreeType(name, color, texture);

                _treeTypes.Add(result);
            }

            return result;
        }
    }
}