namespace Shooter_Game;

public partial class SaveLoad : ContentPage
{
	public SaveLoad()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }

    private void Save1_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Load1_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Delete1_Button_Clicked(object sender, EventArgs e)
    {

    }
}