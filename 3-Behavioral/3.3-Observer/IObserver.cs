namespace DesignPattern_3_Behavioral_3_3_Observer
{
    public interface IObserver
    {
        string Name {get; set;}
        void Update(Subject subject);
    }
}