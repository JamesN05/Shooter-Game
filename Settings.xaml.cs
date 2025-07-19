namespace Shooter_Game;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }

    private void Easy_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Standard_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Hard_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Small_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Medium_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Large_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Auto_Save_Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Tips_Button_Clicked(object sender, EventArgs e)
    {

    }
}