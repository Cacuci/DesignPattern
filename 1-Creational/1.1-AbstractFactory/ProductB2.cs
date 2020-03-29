
namespace DesignPattern._1_Creational._1._1_AbstractFactory
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            System.Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}