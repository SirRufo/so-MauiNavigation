namespace MyApp.Pages;

public partial class PageOnePage : ContentPage
{
    public PageOnePage()
    {
        InitializeComponent();
    }

    async void Button_Clicked( System.Object sender, System.EventArgs e )
    {
        await Shell.Current.GoToAsync( "two" );
    }
}
