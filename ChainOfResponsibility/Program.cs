global using System;

namespace ChainOfResponsibility;
class Program
{
    static void Main(string[] args)
    {
        var requestHookChain = new RequestHookChain(new Writer("hello start of chain"));

        requestHookChain.AddLink(new NewLiner());
        try
        {
            requestHookChain.AddLink(new Writer("Should throw"));
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error accured with message:");
            Console.WriteLine(ex.Message);
        }

        requestHookChain.HandleChain();
    }
}
