namespace Shooter_Game;

public partial class Settings : ContentPage
{
    //Storing starting screen as a variable so the ui can change from this page
    private MainPage MainPage;

    //Stored publicly for use in starting screen page
    public bool Tips_On;

	public Settings(MainPage mainPage)
	{
		InitializeComponent();

        MainPage = mainPage;

        //Stored in preferences for use in starting screen
        Tips_On = Preferences.Get("Tips_On", true);
        Tips_Button_Ui();
	}

    //Go back to starting screen
    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }

    //Buttons change colour for 1 second before going back to normal upon being clicked
    //Clears stats stored in preferences
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

        //Wait for 1 secnd
        await Task.Delay(1000);

        Local_Save_Button.Background = new SolidColorBrush(Colors.SaddleBrown);
    }

    //Toggle tips on and off
    private void Tips_Button_Clicked(object sender, EventArgs e)
    {
        Tips_On = !Tips_On;

        Preferences.Set("Tips_On", Tips_On);

        Tips_Button_Ui();
    }

    //Change UI for button based on it being on or off
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