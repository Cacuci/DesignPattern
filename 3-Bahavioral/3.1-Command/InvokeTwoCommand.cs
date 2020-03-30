
public class InvokeTwoCommand : ICommand
{
    private IReceive _receive;

    public InvokeTwoCommand(IReceive receive)
    {
        _receive = receive;
    }

    public void Execute()
    {
        _receive.Open();
    }
}
