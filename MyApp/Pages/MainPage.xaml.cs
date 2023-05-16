namespace MyApp.Pages;

public partial class MainPage : ContentPage
{
    private readonly IMyNavigationService _navigationService;

    public MainPage( IMyNavigationService navigationService )
    {
        InitializeComponent();
        _navigationService = navigationService;
    }

    async void OneButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "one" );
    }

    async void TwoButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "two" );
    }

    async void LogoutButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "//login" );
    }
}
