namespace Composite
{
    // A classe Composite representa os componentes complexos que podem ter
    // crianças. Normalmente, os objetos Composite delegam o trabalho real para
    // seus filhos e então "resume" o resultado.
    internal class Composite : Componet
    {
        protected IList<Componet> _children = [];

        // O Composite executa sua lógica primária de uma maneira particular. Isto
        // percorre recursivamente todos os seus filhos, coletando e
        // somando seus resultados. Cada filho do Composite passam por ele,
        // que chamam seus filhos e assim por diante, toda a árvore de objetos é
        // percorrido como resultado.
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Componet component in _children)
            {
                result += component.Operation();

                if (i != this._children.Count - 1)
                {
                    result += "+";
                }

                i++;
            }

            return result + ")";
        }

        public override void Add(Componet componet)
        {
            _children.Add(componet);
        }

        public override void Remove(Componet componet)
        {
            _children.Remove(componet);
        }
    }
}