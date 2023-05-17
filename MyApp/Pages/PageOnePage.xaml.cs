namespace MyApp.Pages;

public partial class PageOnePage : ContentPage
{
    private readonly IMyNavigationService _navigationService;

    public PageOnePage( IMyNavigationService navigationService )
    {
        InitializeComponent();
        _navigationService = navigationService;
    }

    async void Button_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "two" );
    }

    async void MainButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( "//MainPage" );
    }

    async void BackButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await _navigationService.GoToAsync( ".." );
    }
}
