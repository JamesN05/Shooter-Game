using Microsoft.Maui.Dispatching;
using System.Timers;

namespace Shooter_Game;

public partial class GamePage : ContentPage
{
    private bool Running = false;
    private IDispatcherTimer timer;
    private int count = 4;

    public GamePage()
    {
        InitializeComponent();

        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Countdown;
        timer.Start();
    }

    

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }

    private void Countdown(object sender, EventArgs e)
    {
        if (Running == false)
        {
            if (count >= 2)
            {
                count--;
                Start_Countdown.Text = count.ToString();
            }
            else if (count == 1)
            {
                count--;
                Start_Countdown.Text = "Go!";
            }
            else if (count == 0)
            {
                Current_Weapon.IsVisible = true;
                Ammo.IsVisible = true;
                Play_Area.IsVisible = true;
                Round_Count.IsVisible = true;

                Count_Txt.IsVisible = false;
                Start_Countdown.IsVisible = false;

                Running = true;
            }
        }
    }
}