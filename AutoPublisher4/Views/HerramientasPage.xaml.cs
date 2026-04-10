using AutoPublisher4.ViewModels;

namespace AutoPublisher4.Views;

public partial class HerramientasPage : ContentPage
{
    private readonly HerramientasViewModel _viewModel;

    public HerramientasPage(HerramientasViewModel viewModel)
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
