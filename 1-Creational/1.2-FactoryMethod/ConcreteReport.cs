namespace DesignPattern._1_Creational._1._2_FactoryMethod
{
    class ConcreteReport : DocumentFactory
    {
        public override void CreatePage()
        {
            Pages.Add(new IntrodutionPage());
            Pages.Add(new ResultPage());
        }
    }
}