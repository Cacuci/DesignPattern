using FlyWeight;

// As classes Tree (Árvore) e Forest (Floresta) são os clientes
// flyweight. Você pode uni-las se não planeja desenvolver mais
// a classe Tree.

var forest = new Forest();

decimal x, y;
string name, color, texture;

x = 5; y = 10; name = "Goiabeira"; color = "Branco"; texture = "Aspero";

forest.PlantTree(x, y, name, color, texture);

x = 1; y = 10; name = "Goiabeira"; color = "Preto"; texture = "Aspero";

forest.PlantTree(x, y, name, color, texture);

x = 2; y = 5; name = "Goiabeira"; color = "Branco"; texture = "Aspero";

forest.PlantTree(x, y, name, color, texture);

forest.Draw();