namespace Shooter_Game;

public partial class Stats : ContentPage
{
	public Stats()
	{
		InitializeComponent();

        Gold_Count.Text = Player_Stats.Gold.ToString();
        Bullet_Damage.Text = Player_Stats.Bullet_Damage.ToString();
        Bullet_Speed.Text = Player_Stats.Bullet_Speed.ToString();
        Mag_Size.Text = Player_Stats.Mag_Capacity.ToString();
    }

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }

    private void Buy_Bullet_Damage_Clicked(object sender, EventArgs e)
    {
        if (Player_Stats.Gold >= 100)
        {
            Player_Stats.Gold -= 100;
            Player_Stats.Bullet_Damage += 20;

            Gold_Count.Text = Player_Stats.Gold.ToString();
            Bullet_Damage.Text = Player_Stats.Bullet_Damage.ToString();
        }
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
    }
}