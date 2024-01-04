
using Volo.Abp.DependencyInjection;

namespace XSX.Garden.MAUI.ViewModels;

public partial class BaseViewModel : ObservableObject, ITransientDependency
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
}
public partial class BaseViewModelTransient : BaseViewModel, ITransientDependency
{

}
public partial class BaseViewModelSingleton : BaseViewModel, ISingletonDependency
{

}