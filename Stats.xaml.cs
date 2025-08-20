namespace Shooter_Game;

public partial class Stats : ContentPage
{
	public Stats()
	{
		InitializeComponent();

        //Load preferences for display
        Player_Stats.Load_Locally();

        //Display info
        Gold_Count.Text = Player_Stats.Gold.ToString();
        Bullet_Damage.Text = Player_Stats.Bullet_Damage.ToString();
        Bullet_Speed.Text = Player_Stats.Bullet_Speed.ToString();
        Mag_Size.Text = Player_Stats.Mag_Capacity.ToString();

        Highest_Round.Text = "Round: " + Player_Stats.Highest_Round.ToString();
        Highest_Zombie_Kills.Text = "Zombies Killed: " + Player_Stats.Highest_Zombies_Killed.ToString();
        Highest_Gold_Earned.Text = "Gold Earned: " + Player_Stats.Highest_Gold_Earned.ToString();
        Highest_PowerUps_PickedUp.Text = "Power Ups Picked Up: " + Player_Stats.Highest_PowerUps_PickedUp.ToString();

        Last_Round.Text = "Round: " + Player_Stats.Last_Round.ToString();
        Last_Zombie_Kills.Text = "Zombies Killed: " + Player_Stats.Last_Zombies_Killed.ToString();
        Last_Gold_Earned.Text = "Gold Earned: " + Player_Stats.Last_Gold_Earned.ToString();
        Last_PowerUps_PickedUp.Text = "Power Ups Picked Up: " + Player_Stats.Last_PowerUps_PickedUp.ToString();
    }

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }

    //Buttons to use gold to upgrade stats
    private void Buy_Bullet_Damage_Clicked(object sender, EventArgs e)
    {
        if (Player_Stats.Gold >= 100)
        {
            Player_Stats.Gold -= 100;
            Player_Stats.Bullet_Damage += 20;

            Gold_Count.Text = Player_Stats.Gold.ToString();
            Bullet_Damage.Text = Player_Stats.Bullet_Damage.ToString();
        }

        Player_Stats.Save_Locally();
    }

    private void Buy_Bullet_Speed_Clicked(object sender, EventArgs e)
    {
        if (Player_Stats.Gold >= 100)
        {
            Player_Stats.Gold -= 100;
            Player_Stats.Bullet_Speed += 1;

            Gold_Count.Text = Player_Stats.Gold.ToString();
            Bullet_Speed.Text = Player_Stats.Bullet_Speed.ToString();
        }

        Player_Stats.Save_Locally();
    }

    private void Buy_Mag_Size_Clicked(object sender, EventArgs e)
    {
        if (Player_Stats.Gold >= 100)
        {
            Player_Stats.Gold -= 100;
            Player_Stats.Mag_Capacity += 2;

            Gold_Count.Text = Player_Stats.Gold.ToString();
            Mag_Size.Text = Player_Stats.Mag_Capacity.ToString();
        }

        Player_Stats.Save_Locally();
    }
}