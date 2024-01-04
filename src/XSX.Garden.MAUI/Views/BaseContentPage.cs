namespace XSX.Garden.MAUI.Views;

public partial class BaseContentPage : ContentPage, ITransientDependency
{
    public BaseContentPage(BaseViewModel viewModel)
    {
        BindingContext = viewModel;
    }
}