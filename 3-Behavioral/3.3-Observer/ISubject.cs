namespace DesignPattern_3_Behavioral_3_3_Observer
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify();
    }
}