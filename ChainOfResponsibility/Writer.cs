namespace ChainOfResponsibility;
public class Writer : HookHandler
{
    private string _message;

    public Writer(string message)
    {
        _message = message;
    }

    public override void Handle()
    {
        Console.WriteLine(_message);
        base.Handle();
    }
}