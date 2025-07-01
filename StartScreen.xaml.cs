namespace Shooter_Game
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Settings_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private async void SaveLoad_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SaveLoad(), true);
        }

        private async void Start_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private async void Stats_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private async void Shop_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private async void Catalogue_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private async void Credits_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }
    }
}
