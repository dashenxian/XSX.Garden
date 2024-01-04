namespace XSX.Garden.MAUI.Services;

public class HelloWorldService : ITransientDependency
{
    public string SayHello()
    {
        return "Hello, World!123";
    }
}