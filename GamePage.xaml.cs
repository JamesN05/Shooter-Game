using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Dispatching;
using System.Timers;

namespace Shooter_Game;

public partial class GamePage : ContentPage
{
    private IDispatcherTimer Timer;
    Random random = new Random();

    private List<Image> Zombies_Active = new List<Image>();
    private List<Image> Bullets_Active = new List<Image>();
    private List<int> Zombies_Health = new List<int>();

    private bool Running = false;
    private bool Mag_Loaded = true;
    private int Count = 4;
    private int Ammo = 28;
    private int Round = 1;
    private int zombie_speed = 1;
    private int zombies_spawned = 10;
    private int zombie_health = 20;
    private int bullet_damage = 20;
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

    private async void Game_Active()
    {
        int rand_interval;
        int spawn_delay = 9;

        while (Running)
        {
            await Task.Delay(3000);

            for (int i = zombies_spawned; i >= 1; i--)
            {
                Zombie_Spawn();

                rand_interval = random.Next(1, spawn_delay);

                await Task.Delay(rand_interval * 1000);

                if (!Running)
                    break;
            }

            while (Zombies_Active.Count > 0)
            {
                await Task.Delay(100);

                if (!Running)
                    break;
            }

            zombies_spawned++;
            zombie_speed++;
            Round++;

            zombie_health += 20;

            if (spawn_delay >= 3)
                spawn_delay--;

            Round_Count.Text = "Round: " + Round.ToString();
        }
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
            Bullets_Active.Add(Bullet_Img);

            Ammo--;
            Ammo_Count.Text = Ammo.ToString() + "/28";

            if (Ammo == 0)
                Mag_Loaded = false;

            _ = Bullet_Movement(Bullet_Img);
        }
    }

    private async Task Bullet_Movement(Image Bullet)
    {
        int distance = 10;

        while (true)
        {
            var bullet_position = AbsoluteLayout.GetLayoutBounds(Bullet);

            double new_position = bullet_position.Y - distance;

            if (new_position + Bullet.Height < 0)
            {
                Play_Area.Children.Remove(Bullet);
                Bullets_Active.Remove(Bullet);

                break;
            }

            AbsoluteLayout.SetLayoutBounds(Bullet, new Rect(bullet_position.X, new_position, Bullet.WidthRequest, Bullet.HeightRequest));

            if (Check_Collision(Bullet))
                break;

            await Task.Delay(16);
        }
    }

    private bool Collision(View Obj1, View Obj2)
    {
        var obj1_position = AbsoluteLayout.GetLayoutBounds(Obj1);
        var obj2_position = AbsoluteLayout.GetLayoutBounds(Obj2);

        return obj1_position.X < obj2_position.X + obj2_position.Width
               && obj1_position.X + obj1_position.Width > obj2_position.X
               && obj1_position.Y < obj2_position.Y + obj2_position.Height
               && obj1_position.Y + obj1_position.Height > obj2_position.Y;
    }

    private bool Check_Collision(Image Bullet)
    {
        foreach (var Zombie in Zombies_Active.ToList())
        {
            if (Collision(Bullet, Zombie))
            {
                Play_Area.Children.Remove(Bullet);
                Bullets_Active.Remove(Bullet);

                int index = Zombies_Active.IndexOf(Zombie);

                Zombies_Health[index] -= bullet_damage;

                if (Zombies_Health[index] <= 0)
                {
                    Play_Area.Children.Remove(Zombie);
                    Zombies_Active.Remove(Zombie);
                    Zombies_Health.RemoveAt(index);
                }

                return true;
            }
        }

        return false;
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

    private void Zombie_Spawn()
    {
        int rand_spawn;

        var Zombie = new Zombie();

        var Zombie_Img = Zombie.Zombie_Img;

        rand_spawn = random.Next(50, 1450);

        AbsoluteLayout.SetLayoutBounds(Zombie_Img, new Rect(rand_spawn, 70, Zombie_Img.WidthRequest, Zombie_Img.HeightRequest));

        Play_Area.Children.Add(Zombie_Img);
        Zombies_Active.Add(Zombie_Img);

        Zombies_Health.Add(zombie_health);

        _ = Zombie_Move(Zombie_Img);
    }

    private async Task Zombie_Move(Image Zombie)
    {
        while (true)
        {
            if (!Zombies_Active.Contains(Zombie) || !Running)
                break;

            var zombie_position = AbsoluteLayout.GetLayoutBounds(Zombie);
            var char_position = AbsoluteLayout.GetLayoutBounds(Player_Char);

            double new_position = zombie_position.Y + zombie_speed;

            AbsoluteLayout.SetLayoutBounds(Zombie, new Rect(zombie_position.X, new_position, Zombie.WidthRequest, Zombie.HeightRequest));

            if (!Running)
                break;

            if (Check_Y_Axis_Collision(Zombie))
            {
                Game_Over();
                break;
            }

            await Task.Delay(16);
        }
    }
    private bool Y_Axis_Collision(View Obj1, View Obj2)
    {
        var obj1_position = AbsoluteLayout.GetLayoutBounds(Obj1);
        var obj2_position = AbsoluteLayout.GetLayoutBounds(Obj2);

        return obj1_position.Y < obj2_position.Y + obj2_position.Height
               && obj1_position.Y + obj1_position.Height > obj2_position.Y;
    }

    private bool Check_Y_Axis_Collision(Image Zombie)
    {
        if (Y_Axis_Collision(Zombie, Player_Char))
        {
                return true;
        }

        return false;
    }

    private async void Game_Over()
    {
        if (!Running)
            return;

        Running = false;
        Timer.Stop();

        foreach (var zombie in Zombies_Active.ToList())
        {
            Play_Area.Children.Remove(zombie);
            Zombies_Active.Remove(zombie);
        }

        foreach (var bullet in  Bullets_Active.ToList())
        {
            Play_Area.Children.Remove(bullet);
            Bullets_Active.Remove(bullet);
        }
        
        Ammo_Count.IsVisible = false;
        Play_Area.IsVisible = false;
        Round_Count.IsVisible = false;

        Start_Countdown.IsVisible = true;
        Start_Countdown.Text = "Game Over!";

        await Task.Delay(3000);

        await Navigation.PopModalAsync(true);

        return;
    }
}