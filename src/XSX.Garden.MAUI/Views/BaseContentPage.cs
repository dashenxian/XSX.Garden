
namespace XSX.Garden.MAUI.Views;

public partial class BaseContentPage : ContentPage, ITransientDependency
{
    public IAbpLazyServiceProvider LazyServiceProvider { get; set; } = default!;
    protected ILoggerFactory LoggerFactory => LazyServiceProvider.LazyGetRequiredService<ILoggerFactory>();
    protected ILogger Logger => LazyServiceProvider.LazyGetService<ILogger>(provider => LoggerFactory?.CreateLogger(GetType().FullName!) ?? NullLogger.Instance);
    public BaseContentPage(BaseViewModel viewModel)
    {
        BindingContext = viewModel;
    }
}