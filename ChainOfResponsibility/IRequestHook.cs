namespace ChainOfResponsibility;
public interface IRequestHook
{
    void Handle();
    void RegisterSuccessor(IRequestHook handler);
}