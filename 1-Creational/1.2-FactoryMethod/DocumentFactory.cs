using System.Collections.Generic;

namespace DesignPattern._1_Creational._1._2_FactoryMethod
{
    abstract class DocumentFactory
    {
        private List<Page> pages = new List<Page>();

        public List<Page> Pages { get => pages; }

        // Constructor calls abstract Factory method        
        public DocumentFactory() => CreatePage();

        // Factory Method
        public abstract void CreatePage();        
    }
}