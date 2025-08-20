namespace Shooter_Game;

public partial class Catalogue : ContentPage
{
	public Catalogue()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }
}