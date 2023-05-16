using Microsoft.Extensions.Logging;

using MyApp.Pages;

namespace MyApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts( fonts =>
            {
                fonts.AddFont( "OpenSans-Regular.ttf", "OpenSansRegular" );
                fonts.AddFont( "OpenSans-Semibold.ttf", "OpenSansSemibold" );
            } );

        builder.Services
            .AddSingleton<IMyNavigationService, MyNavigationService>()

            .AddTransient<AppShell>()
            .AddTransient<LoginPage>()

            .AddTransient<MainPage>()
            .AddTransient<PageOnePage>()
            .AddTransient<PageTwoPage>()
            ;

        Routing.RegisterRoute( "one", typeof( PageOnePage ) );
        Routing.RegisterRoute( "two", typeof( PageTwoPage ) );

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
