namespace ChainOfResponsibility;
public abstract class HookHandler : IRequestHook
{
    private IRequestHook _successor;

    public virtual void Handle()
    {
        if (_successor != null)
            _successor.Handle();
    }

    public void RegisterSuccessor(IRequestHook hook)
    {
        if (_successor == null)
            _successor = hook;
        else
            throw new InvalidOperationException($"Successor for {typeof(Writer)} has already been registered");
    }
}