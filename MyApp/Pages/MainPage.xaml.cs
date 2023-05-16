namespace MyApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void OneButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await Shell.Current.GoToAsync( "one" );
    }

    async void TwoButton_Clicked( System.Object sender, System.EventArgs e )
    {
        await Shell.Current.GoToAsync( "two" );
    }
}
