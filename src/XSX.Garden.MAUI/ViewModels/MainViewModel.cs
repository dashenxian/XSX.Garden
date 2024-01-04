namespace XSX.Garden.MAUI.ViewModels;

public class MainViewModel : BaseViewModelTransient
{
    private readonly HelloWorldService _helloWorldService;
    public MainViewModel(HelloWorldService helloWorldService)
    {
        _helloWorldService = helloWorldService;
    }

    public string HelloLabText
    {
        get => _helloWorldService.SayHello();
    }
}