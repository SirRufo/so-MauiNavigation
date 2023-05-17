namespace MyApp.Pages;

public partial class PageTwoPage : ContentPage
{
    private readonly IMyNavigationService _navigationService;

    public PageTwoPage( IMyNavigationService navigationService )
    {
        InitializeComponent();
        _navigationService = navigationService;
    }

    async void Button_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "one" );
    }

    async void BackButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( ".." );
    }
}
