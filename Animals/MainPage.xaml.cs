using Animals.ViewModels;

namespace Animals;

public partial class MainPage : ContentPage
{
    public MainViewModel ViewModel => this.BindingContext as MainViewModel;

    public static string PageName => nameof(MainPage);

    public MainPage(MainViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}
