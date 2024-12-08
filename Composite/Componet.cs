namespace Composite
{

    // A classe base Component declara operações comuns para operações simples e
    // objetos complexos de uma composição.
    internal abstract class Componet
    {
        // O componente base pode implementar algum comportamento padrão ou deixá-lo
        // para aas classes concretas (declarando o método que contém o comportamento como
        // "abstract").
        public abstract string Operation();

        // Em alguns casos, seria benéfico definir o modelo de gestão de operação dos filhos
        // diretamente na classe Component (base). Dessa forma, você não vai
        // precisa expor quaisquer classes de componentes concretas ao código do cliente,
        // mesmo durante a montagem da árvore de objetos. A desvantagem é que esses
        // os métodos estarão vazios para os componentes de nível folha.
        public virtual void Add(Componet componet)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Componet componet)
        {
            throw new NotImplementedException();
        }

        // Você pode fornecer um método que permite ao código do cliente descobrir se
        // um componente pode gerar filhos.
        public virtual bool IsComposite()
        {
            throw new NotImplementedException();
        }
    }
}