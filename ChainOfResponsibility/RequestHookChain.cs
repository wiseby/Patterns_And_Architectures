using System.Collections.Generic;

namespace ChainOfResponsibility;
public class RequestHookChain
{
    private IRequestHook initialHook;
    private IRequestHook lastRequestHook;
    private HashSet<string> registeredHooks = new HashSet<string>();

    public RequestHookChain(IRequestHook initialHook)
    {
        this.initialHook = initialHook;
        this.lastRequestHook = initialHook;
    }

    public void HandleChain()
    {
        if (initialHook != null)
            initialHook.Handle();
    }

    public void AddLink(IRequestHook handler)
    {
        try
        {
            if (!registeredHooks.Add(nameof(handler)))
                throw new ArgumentException("handler has already been added to the chain. A handler can only be in the chain once.");

            this.lastRequestHook.RegisterSuccessor(handler);

        }
        catch (ArgumentException ex)
        {
            throw ex;
        }
    }
}