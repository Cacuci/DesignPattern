namespace Facade
{
    // Algumas fachadas podem funcionar com vários subsistemas ao mesmo tempo.
    internal class SubSystem2
    {
        public string Operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string OperationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}