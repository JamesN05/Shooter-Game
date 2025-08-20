namespace Shooter_Game;

public partial class SaveLoad : ContentPage
{
	public SaveLoad()
	{
		InitializeComponent();
	}

    private async void Return_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }

    private async void Save1_Button_Clicked(object sender, EventArgs e)
    {
        Save1_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save1.txt");
        StreamWriter outputFile = new StreamWriter(filePath);

        Save_to_File(outputFile);

        outputFile.Close();

        await Task.Delay(1000);

        Save1_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Load1_Button_Clicked(object sender, EventArgs e)
    {
        Load1_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save1.txt");
        StreamReader inputFile = new StreamReader(filePath);

        Load_from_File(inputFile);

        inputFile.Close();

        await Task.Delay(1000);

        Load1_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Delete1_Button_Clicked(object sender, EventArgs e)
    {
        Delete1_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save1.txt");
        StreamWriter clearFile = new StreamWriter(filePath);

        Reset_File(clearFile);

        clearFile.Close();

        await Task.Delay(1000);

        Delete1_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Save2_Button_Clicked(object sender, EventArgs e)
    {
        Save2_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save2.txt");
        StreamWriter outputFile = new StreamWriter(filePath);

        Save_to_File(outputFile);

        outputFile.Close();

        await Task.Delay(1000);

        Save2_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Load2_Button_Clicked(object sender, EventArgs e)
    {
        Load2_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save2.txt");
        StreamReader inputFile = new StreamReader(filePath);

        Load_from_File(inputFile);

        inputFile.Close();

        await Task.Delay(1000);

        Load2_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Delete2_Button_Clicked(object sender, EventArgs e)
    {
        Delete2_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save2.txt");
        StreamWriter clearFile = new StreamWriter(filePath);

        Reset_File(clearFile);

        clearFile.Close();

        await Task.Delay(1000);

        Delete2_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Save3_Button_Clicked(object sender, EventArgs e)
    {
        Save3_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save3.txt");
        StreamWriter outputFile = new StreamWriter(filePath);

        Save_to_File(outputFile);

        outputFile.Close();

        await Task.Delay(1000);

        Save3_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Load3_Button_Clicked(object sender, EventArgs e)
    {
        Load3_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save3.txt");
        StreamReader inputFile = new StreamReader(filePath);

        Load_from_File(inputFile);

        inputFile.Close();

        await Task.Delay(1000);

        Load3_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Delete3_Button_Clicked(object sender, EventArgs e)
    {
        Delete3_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save3.txt");
        StreamWriter clearFile = new StreamWriter(filePath);

        Reset_File(clearFile);

        clearFile.Close();

        await Task.Delay(1000);

        Delete3_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Save4_Button_Clicked(object sender, EventArgs e)
    {
        Save4_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save4.txt");
        StreamWriter outputFile = new StreamWriter(filePath);

        Save_to_File(outputFile);

        outputFile.Close();

        await Task.Delay(1000);

        Save4_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Load4_Button_Clicked(object sender, EventArgs e)
    {
        Load4_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save4.txt");
        StreamReader inputFile = new StreamReader(filePath);

        Load_from_File(inputFile);

        inputFile.Close();

        await Task.Delay(1000);

        Load4_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Delete4_Button_Clicked(object sender, EventArgs e)
    {
        Delete4_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save4.txt");
        StreamWriter clearFile = new StreamWriter(filePath);

        Reset_File(clearFile);

        clearFile.Close();

        await Task.Delay(1000);

        Delete4_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Save5_Button_Clicked(object sender, EventArgs e)
    {
        Save5_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save5.txt");
        StreamWriter outputFile = new StreamWriter(filePath);

        Save_to_File(outputFile);

        outputFile.Close();

        await Task.Delay(1000);

        Save5_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Load5_Button_Clicked(object sender, EventArgs e)
    {
        Load5_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save5.txt");
        StreamReader inputFile = new StreamReader(filePath);

        Load_from_File(inputFile);

        inputFile.Close();

        await Task.Delay(1000);

        Load5_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private async void Delete5_Button_Clicked(object sender, EventArgs e)
    {
        Save1_Button.Background = new SolidColorBrush(Colors.DarkRed);

        string filePath = Path.Combine(FileSystem.AppDataDirectory, "Save5.txt");
        StreamWriter clearFile = new StreamWriter(filePath);

        Reset_File(clearFile);

        clearFile.Close();

        await Task.Delay(1000);

        Save1_Button.Background = new SolidColorBrush(Colors.LawnGreen);
    }

    private void Save_to_File(StreamWriter outputFile)
    {
        outputFile.WriteLine(Player_Stats.Gold);

        outputFile.WriteLine(Player_Stats.Bullet_Damage);
        outputFile.WriteLine(Player_Stats.Bullet_Speed);
        outputFile.WriteLine(Player_Stats.Mag_Capacity);

        outputFile.WriteLine(Player_Stats.Highest_Round);
        outputFile.WriteLine(Player_Stats.Highest_Zombies_Killed);
        outputFile.WriteLine(Player_Stats.Highest_PowerUps_PickedUp);
        outputFile.WriteLine(Player_Stats.Highest_Gold_Earned);

        outputFile.WriteLine(Player_Stats.Last_Round);
        outputFile.WriteLine(Player_Stats.Last_Zombies_Killed);
        outputFile.WriteLine(Player_Stats.Last_PowerUps_PickedUp);
        outputFile.WriteLine(Player_Stats.Last_Gold_Earned);
    }

    private void Load_from_File(StreamReader inputFile)
    {
        List<string> data = new List<string>();

        string line = "";

        while ((line = inputFile.ReadLine()) != null)
        {
            data.Add((line));
        }

        Player_Stats.Gold = int.Parse(data[0]);
        
        Player_Stats.Bullet_Damage = int.Parse(data[1]);
        Player_Stats.Bullet_Speed = int.Parse(data[2]);
        Player_Stats.Mag_Capacity = int.Parse(data[3]);

        Player_Stats.Highest_Round = int.Parse(data[4]);
        Player_Stats.Highest_Zombies_Killed = int.Parse(data[5]);
        Player_Stats.Highest_PowerUps_PickedUp = int.Parse(data[6]);
        Player_Stats.Highest_Gold_Earned = int.Parse(data[7]);
        
        Player_Stats.Last_Round = int.Parse(data[8]);
        Player_Stats.Last_Zombies_Killed = int.Parse(data[9]);
        Player_Stats.Last_PowerUps_PickedUp = int.Parse(data[10]);
        Player_Stats.Last_Gold_Earned = int.Parse(data[11]);

        Player_Stats.Load_Locally();
    }

    private void Reset_File(StreamWriter clearFile)
    {
        clearFile.WriteLine(0);

        clearFile.WriteLine(20);
        clearFile.WriteLine(5);
        clearFile.WriteLine(10);

        clearFile.WriteLine(0);
        clearFile.WriteLine(0);
        clearFile.WriteLine(0);
        clearFile.WriteLine(0);

        clearFile.WriteLine(0);
        clearFile.WriteLine(0);
        clearFile.WriteLine(0);
        clearFile.WriteLine(0);
    }
}