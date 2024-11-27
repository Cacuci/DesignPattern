using Composite;

Client client = new();

// Desta forma o código do cliente pode suportar a folha simples
// componentes...
Leaf leaf = new();

Console.WriteLine("Cliente: eu tenho um componente simples");

client.ClientCode(leaf);


// ...assim como os compostos complexos.
Composite.Composite tree = new();

Composite.Composite branch1 = new();

branch1.Add(new Leaf());
branch1.Add(new Leaf());

Composite.Composite branch2 = new();

branch2.Add(new Leaf());

tree.Add(branch1);
tree.Add(branch2);

Console.WriteLine("Cliente: agora eu tenho uma composição de árvore:");
client.ClientCode(tree);

Console.WriteLine("Cliente: não preciso verificar as classes dos componetes, mesmo ao gerenciar a árvore:\n");
client.ClientCode(tree, leaf);