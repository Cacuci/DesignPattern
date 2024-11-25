using Prototype;

// O protótipo arrasa porque permite que você produza
// uma cópia de um objeto sem saber coisa alguma sobre
// seu tipo.
Shape[] shapes = new Shape[2];

var rectangle = new Rectangle(width: 10, height: 20, x: 10, y: 15);

// Por exemplo, nós não sabemos os elementos exatos no
// vetor shapes. Tudo que sabemos é que eles são todos
// shapes. Mas graças ao polimorfismo, quando nós
// chamamos o método `clone` em um shape, o programa
// checa sua classe real e executa o método de clonagem
// apropriado definido naquela classe. É por isso que
// obtemos clones apropriados ao invés de um conjunto de
// objetos Shape simples.
shapes.SetValue(rectangle, 0);

var clone = rectangle.Clone();

shapes.SetValue(clone, 1);

rectangle.UpdateWidth(15);

Console.WriteLine(shapes[0].Equals(shapes[1]));

Console.ReadKey();