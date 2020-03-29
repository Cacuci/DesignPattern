
namespace DesignPattern._1_Creational._1._1_AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateFactoryA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateFactotyB()
        {
            return new ProductB1();
        }
    }
}