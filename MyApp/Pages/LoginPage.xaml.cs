namespace MyApp.Pages;

public partial class LoginPage : ContentPage
{
    private readonly IMyNavigationService _navigationService;

    public LoginPage( IMyNavigationService navigationService )
    {
        InitializeComponent();
        _navigationService = navigationService;
    }

    async void Button_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "//MainPage" );
    }
}
