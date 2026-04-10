using Microsoft.Extensions.Logging;
using AutoPublisher4.ViewModels;
using AutoPublisher4.Views;

namespace AutoPublisher4
{
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

            // ViewModels
            builder.Services.AddTransient<PublicacionViewModel>();
            builder.Services.AddTransient<PublicarViewModel>();
            builder.Services.AddTransient<CuentasCorreoViewModel>();
            builder.Services.AddTransient<HerramientasViewModel>();
            builder.Services.AddTransient<ConfiguracionViewModel>();

            // Pages
            builder.Services.AddTransient<PublicacionPage>();
            builder.Services.AddTransient<PublicarPage>();
            builder.Services.AddTransient<CuentasCorreoPage>();
            builder.Services.AddTransient<HerramientasPage>();
            builder.Services.AddTransient<ConfiguracionPage>();

            return builder.Build();
        }
    }
}