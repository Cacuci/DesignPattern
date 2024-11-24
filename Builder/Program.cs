using Builder;

var carbuilder = new CarBuilder();

// O diretor pode construir diversas variações
// do produto usando as mesmas etapas de construção.
var director = new DirectorCar(carbuilder);

director.ConstructSportCar();

director.ConstructSUVCar();

// O produto final é frequentemente retornado de um
// objeto builder uma vez que o diretor não está
// ciente e não é dependente de builders e produtos
// concretos.
var car = carbuilder.GetProduct();

Console.WriteLine();

Console.WriteLine("Tipo " + car.GetType().Name);

Console.WriteLine();

var manualbuilder = new CarManualBuilder();

director = new DirectorCar(manualbuilder);

director.ConstructSportCar();

director.ConstructSUVCar();

// O produto final é frequentemente retornado de um
// objeto builder uma vez que o diretor não está
// ciente e não é dependente de builders e produtos
// concretos.
var manual = manualbuilder.GetProduct();

Console.WriteLine();

Console.WriteLine("Tipo " + manual.GetType().Name);

Console.ReadKey();