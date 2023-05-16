using MyApp.Pages;

namespace MyApp;

public class MyNavigationService : IMyNavigationService
{
    private readonly IServiceProvider _serviceProvider;

    public MyNavigationService( IServiceProvider serviceProvider )
    {
        _serviceProvider = serviceProvider;
    }

    public async Task GoToAsync( string route )
    {
        if ( route == "//login" )
        {
            App.Current.MainPage = _serviceProvider.GetRequiredService<LoginPage>();
        }
        else
        {
            var shell = App.Current.MainPage as AppShell ?? _serviceProvider.GetRequiredService<AppShell>();
            App.Current.MainPage = shell;
            await shell.GoToAsync( route );
        }
    }
}