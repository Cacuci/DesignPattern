using DesignPattern._1_Creational._1._1_AbstractFactory;
using DesignPattern._1_Creational._1._2_FactoryMethod;
using DesignPattern_2_Structural_2_2_Facade;
using DesignPattern_3_Behavioral_3_3_Observer;
using System;
using System.Collections.Generic;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // #region AbstractFactory            

            // AbstractFactory factory1 = new ConcreteFactory1();

            // Client client1 = new Client(factory1);

            // client1.Run();

            // AbstractFactory factory2 = new ConcreteFactory2();

            // Client client2 = new Client(factory2);

            // client2.Run();

            // #endregion

            // #region FactoryMethod

            // // Note: constructors call Factory Method
            // DocumentFactory[] documents = new DocumentFactory[2];                       

            // documents[0] = new ConcreteResume();
            // documents[1] = new ConcreteReport();

            // foreach (var document in documents)
            // {
            //     Console.WriteLine(Environment.NewLine + document.GetType().Name + " -- ");

            //     foreach (var page in document.Pages)
            //     {
            //         Console.WriteLine(page.GetType().Name);
            //     }
            // }

            // #endregion

            /*   #region Adapter

              ITarget target = new Target();

              target.Requests();

              ITarget target1 = new Adapter();

              target1.Requests();

              #endregion   */

            /* #region Singleton
            Singleton singlone = Singleton.Instance();
            Singleton singletwo = Singleton.Instance();            

            System.Console.WriteLine("SingleOne {0}: ", singlone.ID);
            System.Console.WriteLine("SingleOne {0}: ", singletwo.ID);
            #endregion             */

            /*#region Facade
                
            Computer facade = new Computer();

            facade.StartComputer();            

            #endregion*/

            /*#region Command

            IReceive receive = new Receive();

            ICommand commandOne = new InvokeOneCommand(receive);
            ICommand commandTwo = new InvokeTwoCommand(receive);

            commandOne.Execute();
            commandTwo.Execute();            
                
            #endregion*/

            // #region Strategy

            // var strategyA = new Context(new StrategyA());

            // strategyA.ConcretInterface();

            // var strategyB = new Context(new StrategyB());

            // strategyB.ConcretInterface();

            // #endregion

            // #region Observer

            // Subject subject = new Subject(new List<IObserver>());

            // IObserver observer1 = new Observer("Observer 1", subject);
            // IObserver observer2 = new Observer("Observer 2", subject);
            // IObserver observer3 = new Observer("Observer 3", subject);

            // subject.Subscribe(observer1);
            // subject.Subscribe(observer2);
            // subject.Subscribe(observer3);            

            // subject.EditEdition();            

            // Console.WriteLine();                        

            // subject.EditEdition();          

            // Console.WriteLine();                        

            // subject.UnSubscribe(observer2); 

            // Console.WriteLine();                         

            // subject.EditEdition();                      

            // #endregion

            #region Decorator

            var pizza = new PizzaComponent();
            var chesse = new CheeseDecorator(pizza);
            var tomate = new TomateDecorator(chesse);

            Console.WriteLine($"Decorator Pattern Pizza: {tomate.GetDescription()} - {tomate.CalculateCost()}");
            #endregion

            Console.ReadKey();                
        }
    }
}
