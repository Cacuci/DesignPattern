namespace DesignPattern._1_Creational._1._2_FactoryMethod
{
    class ConcreteResume : DocumentFactory
    {
        public override void CreatePage()
        {
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new SkillsPage());
        }
    }
}