using AutoPublisher4.ViewModels;

namespace AutoPublisher4.Views;

public partial class PublicarPage : ContentPage
{
    private readonly PublicarViewModel _viewModel;

    public PublicarPage(PublicarViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}
