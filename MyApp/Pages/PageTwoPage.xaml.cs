namespace MyApp.Pages;

public partial class PageTwoPage : ContentPage
{
    public PageTwoPage()
    {
        InitializeComponent();
    }

    async void Button_Clicked( System.Object sender, System.EventArgs e )
    {
        await Shell.Current.GoToAsync( "one" );
    }
}
