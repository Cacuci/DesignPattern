
namespace DesignPattern._1_Creational._1._1_AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateFactoryA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateFactotyB()
        {
            return new ProductB2();
        }
    }
}
