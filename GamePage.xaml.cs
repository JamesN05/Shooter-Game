using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Dispatching;
using System.Timers;

namespace Shooter_Game;

public partial class GamePage : ContentPage
{
    private bool Running = false;
    private bool Mag_Loaded = true;
    private IDispatcherTimer Timer;
    Random random = new Random();
    private int Count = 4;
    private int Ammo = 28;
    private int Round = 1;
    private string direction = "left";

    public GamePage()
    {
        InitializeComponent();

        Timer = Dispatcher.CreateTimer();
        Timer.Interval = TimeSpan.FromSeconds(1);
        Timer.Tick += Countdown;
        Timer.Start();
    }

    private void Countdown(object sender, EventArgs e)
    {
        if (Running == false)
        {
            if (Count >= 2)
            {
                Count--;
                Start_Countdown.Text = Count.ToString();
            }
            else if (Count == 1)
            {
                Count--;
                Start_Countdown.Text = "Go!";
            }
            else if (Count == 0)
            {
                Current_Weapon.IsVisible = true;
                Ammo_Count.IsVisible = true;
                Play_Area.IsVisible = true;
                Round_Count.IsVisible = true;

                Count_Txt.IsVisible = false;
                Start_Countdown.IsVisible = false;

                Running = true;
                Game_Active();
            }
        }
    }

    private void Drag_Move(object sender, DragStartingEventArgs e)
    {

    }

    private void Follow_Pointer(object sender, PointerEventArgs e)
    {
        if (!Running)
            return;
        
        Point? Pointer_Position = e.GetPosition(Play_Area);
        
        var position = AbsoluteLayout.GetLayoutBounds(Player_Char);
        double char_x = position.X;

        double pointer_x = Pointer_Position.Value.X;

        const double speed = 5;
        double distance = pointer_x - char_x;
        
        double move = speed * Math.Sign(distance);

        if (Math.Abs(distance) <= speed)
        {
            char_x = pointer_x;
        }
        else
        {
            char_x += move;
        }

        if (char_x > position.X && direction == "left")
        {
            Player_Char.Source = "walking_right.png";

            direction = "right";
        }
        else if (char_x < position.X && direction == "right")
        {
            Player_Char.Source = "walking_left.png";

            direction = "left";
        }

        char_x = Math.Clamp(char_x, 0, Play_Area.Width - Player_Char.Width);

        AbsoluteLayout.SetLayoutBounds(Player_Char, new Rect(char_x, position.Y, position.Width, position.Height));
    }

    private void Shoot(object sender, EventArgs e)
    {
        if (!Running)
            return;

        if (!Mag_Loaded)
            Reload();
        else
        {
            var Bullet = new Bullet();

            var Bullet_Img = Bullet.Bullet_Img;

            var player_position = AbsoluteLayout.GetLayoutBounds(Player_Char);

            double bullet_x = player_position.X;
            double bullet_y = player_position.Y;

            AbsoluteLayout.SetLayoutBounds(Bullet_Img, new Rect(bullet_x, bullet_y, Bullet_Img.WidthRequest, Bullet_Img.HeightRequest));

            Play_Area.Children.Add(Bullet_Img);

            Bullet_Img.TranslateTo(0, -Play_Area.Height, 1000);

            Ammo--;
            Ammo_Count.Text = Ammo.ToString() + "/28";

            if (Ammo == 0)
                Mag_Loaded = false;
        }
    }

    private async void Reload()
    {
        if (Ammo == 0)
            for (int i = 0; i <= 27; i++)
            {
                Ammo++;
                Ammo_Count.Text = Ammo.ToString() + "/28";

                await Task.Delay(30);
            }

        Mag_Loaded = true;
    }

    private async void Game_Active()
    {
        int zombies_spawned = 10;
        int rand_interval;

        await Task.Delay(3000);

        for (int i = zombies_spawned; i >= 1; i--)
        {
            Zombie_Spawn();

            rand_interval = random.Next(1, 9);

            await Task.Delay(rand_interval * 1000);
        }
    }

    private void Zombie_Spawn()
    {
        int rand_spawn;

        var Zombie = new Zombie();

        var Zombie_Img = Zombie.Zombie_Img;

        rand_spawn = random.Next(10, 1490);

        AbsoluteLayout.SetLayoutBounds(Zombie_Img, new Rect(rand_spawn, 70, Zombie_Img.WidthRequest, Zombie_Img.HeightRequest));

        Play_Area.Children.Add(Zombie_Img);

        Zombie_Img.TranslateTo(0, Play_Area.Height, 6000);
    }
}