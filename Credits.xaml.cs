namespace Shooter_Game;

public partial class Credits : ContentPage
{
	public Credits()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }
}