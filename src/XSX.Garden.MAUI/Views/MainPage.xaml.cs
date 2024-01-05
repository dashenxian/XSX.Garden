using Microsoft.Extensions.Logging;

namespace XSX.Garden.MAUI.Views;

public partial class MainPage : BaseContentPage
{
    int count = 0;

    public MainPage(MainViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        
        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";
        Logger.LogDebug(CounterBtn.Text);
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}