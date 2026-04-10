using AutoPublisher4.ViewModels;

namespace AutoPublisher4.Views;

public partial class CuentasCorreoPage : ContentPage
{
    private readonly CuentasCorreoViewModel _viewModel;

    public CuentasCorreoPage(CuentasCorreoViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.CargarCuentasAsync();
    }
}
