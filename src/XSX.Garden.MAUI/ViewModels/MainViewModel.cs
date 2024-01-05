namespace XSX.Garden.MAUI.ViewModels;

public partial class MainViewModel : BaseViewModelTransient
{
    private readonly HelloWorldService _helloWorldService;
    public MainViewModel(HelloWorldService helloWorldService)
    {
        _helloWorldService = helloWorldService;
    }

    public string HelloLabText
    {
        get => _helloWorldService.SayHello().Result;
    }
    [RelayCommand()]
    public void WriteLog()
    {
        //IAccount cachedUserAccount = PublicClientSingleton.Instance.MSALClientHelper.FetchSignedInUserFromCache().Result;

        //_ = Dispatcher.DispatchAsync(async () =>
        //{
        //    if (cachedUserAccount == null)
        //    {
        //        SignInButton.IsEnabled = true;
        //    }
        //    else
        //    {
        //        await Shell.Current.GoToAsync("claimsview");
        //    }
        //});
        _helloWorldService.WriteLog();
        //return true;
    }
}