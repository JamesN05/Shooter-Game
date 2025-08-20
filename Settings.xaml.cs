namespace Shooter_Game;

public partial class Settings : ContentPage
{
    private MainPage MainPage;

    public bool Tips_On;

	public Settings(MainPage mainPage)
	{
		InitializeComponent();

        MainPage = mainPage;

        Tips_On = Preferences.Get("Tips_On", true);
        Tips_Button_Ui();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
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

    private async void Local_Save_Button_Clicked(object sender, EventArgs e)
    {
        Local_Save_Button.Background = new SolidColorBrush(Colors.DarkRed);

        Preferences.Remove(nameof(Player_Stats.Gold));

        Preferences.Remove(nameof(Player_Stats.Bullet_Damage));
        Preferences.Remove(nameof(Player_Stats.Bullet_Speed));
        Preferences.Remove(nameof(Player_Stats.Mag_Capacity));

        Preferences.Remove(nameof(Player_Stats.Highest_Round));
        Preferences.Remove(nameof(Player_Stats.Highest_Zombies_Killed));
        Preferences.Remove(nameof(Player_Stats.Highest_PowerUps_PickedUp));
        Preferences.Remove(nameof(Player_Stats.Highest_Gold_Earned));

        Preferences.Remove(nameof(Player_Stats.Last_Round));
        Preferences.Remove(nameof(Player_Stats.Last_Zombies_Killed));
        Preferences.Remove(nameof(Player_Stats.Last_PowerUps_PickedUp));
        Preferences.Remove(nameof(Player_Stats.Last_Gold_Earned));

        Player_Stats.Save_Locally();

        await Task.Delay(1000);

        Local_Save_Button.Background = new SolidColorBrush(Colors.SaddleBrown);
    }

    private void Tips_Button_Clicked(object sender, EventArgs e)
    {
        Tips_On = !Tips_On;

        Preferences.Set("Tips_On", Tips_On);

        Tips_Button_Ui();
    }

    private void Tips_Button_Ui()
    {
        if (!Tips_On)
        {
            MainPage.Tips_Grid.IsVisible = false;

            Tips_Button.Background = new SolidColorBrush(Colors.DarkRed);
            Tips_Button.Text = "Off";
        }
        else if (Tips_On)
        {
            MainPage.Tips_Grid.IsVisible = true;

            Tips_Button.Background = new SolidColorBrush(Colors.SaddleBrown);
            Tips_Button.Text = "On";
        }
    }
}