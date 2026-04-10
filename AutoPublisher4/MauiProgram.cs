using Microsoft.Extensions.Logging;
using AutoPublisher4.ViewModels;
using AutoPublisher4.Views;

namespace AutoPublisher4;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // ViewModels — Singleton para que el estado persista entre navegaciones
        builder.Services.AddSingleton<PublicacionViewModel>();
        builder.Services.AddSingleton<PublicarViewModel>();
        builder.Services.AddSingleton<CuentasCorreoViewModel>();
        builder.Services.AddSingleton<HerramientasViewModel>();
        builder.Services.AddSingleton<ConfiguracionViewModel>();

        // Pages — Singleton alineado con Shell/TabBar
        builder.Services.AddSingleton<PublicacionPage>();
        builder.Services.AddSingleton<PublicarPage>();
        builder.Services.AddSingleton<CuentasCorreoPage>();
        builder.Services.AddSingleton<HerramientasPage>();
        builder.Services.AddSingleton<ConfiguracionPage>();

        return builder.Build();
    }
}