
namespace DesignPattern._1_Creational._1._1_AbstractFactory
{
    class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateFactoryA();
            _abstractProductB = factory.CreateFactotyB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}