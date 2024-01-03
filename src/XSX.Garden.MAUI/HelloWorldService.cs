using Volo.Abp.DependencyInjection;

namespace XSX.Garden.MAUI;

public class HelloWorldService : ITransientDependency
{
    public string SayHello()
    {
        return "Hello, World!";
    }
}