using System;
using System.Collections.Generic;

namespace DesignPattern_3_Behavioral_3_3_Observer
{
    public class Subject : ISubject
    {

        public Subject(IList<IObserver> observers)
        {
            _observers = observers;
        }
        
        public bool _newEdition;
        private readonly IList<IObserver> _observers;
        private bool NewEdition
         {
              get => _newEdition;
              set
              {
                  if (_newEdition != value)
                  {
                      _newEdition = value;
                      Notify();
                  }
              }
        }

        public void Notify()
        {
            foreach (var item in _observers)
            {
                item.Update(this);
            }
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);            
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers.Remove(observer);            

            Console.WriteLine("Desassociado {0}", observer.Name);
        }

        public void EditEdition()
        {
            if (NewEdition)
            {
                NewEdition = false;
            }
            else
            {
                NewEdition = true;
            }
        }

        public bool GetEdition()
        {
            return NewEdition;
        }     
    }
}