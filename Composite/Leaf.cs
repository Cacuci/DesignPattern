namespace Composite
{
    // A classe Leaf representa os objetos finais de uma composição. Uma folha não pode
    // ter filhos.
    //
    // Normalmente, são os objetos Leaf que fazem o trabalho real, enquanto os objetos Composite
    // delegam apenas para seus subcomponentes.
    internal class Leaf : Componet
    {
        public override string Operation()
        {
            return "Folha";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}