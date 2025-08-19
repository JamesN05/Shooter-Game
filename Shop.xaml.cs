namespace Shooter_Game;

public partial class Shop : ContentPage
{
    public Shop()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }
}