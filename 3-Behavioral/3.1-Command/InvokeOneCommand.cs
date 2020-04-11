
public class InvokeOneCommand : ICommand
{
    private IReceive _receive;

    public InvokeOneCommand(IReceive receive)
    {
        _receive = receive;
    }

    public void Execute()
    {
        _receive.Close();
    }
}
