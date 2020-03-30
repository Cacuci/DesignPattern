
public class Receive : IReceive
{
    public void Close()
    {
        System.Console.WriteLine("Fechar");
    }

    public void Open()
    {
        System.Console.WriteLine("Abrir");
    }
}
