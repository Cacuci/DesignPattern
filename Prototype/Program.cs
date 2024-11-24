using Prototype;

Shape[] shapes = new Shape[2];

var rectangle = new Rectangle(width: 10, height: 20, x: 10, y: 15);

shapes.SetValue(rectangle, 0);

var clone = rectangle.Clone();

shapes.SetValue(clone, 1);

rectangle.UpdateWidth(15);

Console.WriteLine(shapes[0].Equals(shapes[1]));

Console.ReadKey();