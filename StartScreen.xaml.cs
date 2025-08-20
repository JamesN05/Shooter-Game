namespace Shooter_Game
{
    public partial class MainPage : ContentPage
    {
        bool Tips_On = Preferences.Get("Tips_On", true);

        public MainPage()
        {
            InitializeComponent();

            Player_Stats.Load_Locally();

            if (!Tips_On)
            {
                Tips_Grid.IsVisible = false;
            }

            Tip_Display();
        }

        private async void Settings_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(this));
        }

        private async void SaveLoad_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SaveLoad(), true);
        }

        private async void Start_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new GamePage(), true);
        }

        private async void Stats_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Stats(), true);
        }

        private async void Catalogue_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Catalogue(), true);
        }

        private async void Credits_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Credits(), true);
        }

        private async void Tip_Display()
        {
            Random random = new Random();
            int rand = 1;

            while (true)
            {
                rand = random.Next(1, 7);

                if (rand == 1)
                {
                    Title_Tip.Text = "Cheat Death";
                    Tip_Text.Text = "You can't stack Cheat Death perks! If you pick up a Cheat Death perk while one is active it will not stack.";
                }
                else if (rand == 2)
                {
                    Title_Tip.Text = "Zombie Health";
                    Tip_Text.Text = "Zombie's have 20 health from the start and their health increases by 20 each round.";
                }
                else if (rand == 3)
                {
                    Title_Tip.Text = "Round Difficulty";
                    Tip_Text.Text = "Each round the amount of zombies, the zombies' health, speed and spawn rate increase.";
                }
                else if (rand == 4)
                {
                    Title_Tip.Text = "Get Stronger!";
                    Tip_Text.Text = "For 100 gold you can increase your bullet damage, bullet speed or your mag size in the stats page!";
                }
                else if (rand == 5)
                {
                    Title_Tip.Text = "Previous Games";
                    Tip_Text.Text = "Compare stats from your last game and your best game in the stats page.";
                }
                else if (rand == 6)
                {
                    Title_Tip.Text = "Unhappy with Something in the Game?";
                    Tip_Text.Text = "Go to settings to adjust the game ui and settings.";
                }

                await Task.Delay(10000);
            }
        }
    }
}
