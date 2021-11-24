namespace ChainOfResponsibility;
public class NewLiner : HookHandler
{
    public override void Handle()
    {
        Console.WriteLine();
        base.Handle();
    }
}