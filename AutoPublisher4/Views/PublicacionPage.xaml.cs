using AutoPublisher4.ViewModels;

namespace AutoPublisher4.Views;

public partial class PublicacionPage : ContentPage
{
    private readonly PublicacionViewModel _viewModel;

    public PublicacionPage(PublicacionViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.CargarPublicacionesAsync();
    }
}
