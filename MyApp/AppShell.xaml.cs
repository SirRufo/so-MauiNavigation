using MyApp.Pages;

namespace MyApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute( "one", typeof( PageOnePage ) );
        Routing.RegisterRoute( "two", typeof( PageTwoPage ) );
        Routing.RegisterRoute( "MainPage", typeof( MainPage ) );
    }
}

