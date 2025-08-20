using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Player_Stats
    {
        //Storing values for the players stats
        public static int Gold {  get; set; } = 0;

        public static int Bullet_Damage { get; set; } = 20;
        public static int Bullet_Speed { get; set; } = 5;
        public static int Mag_Capacity { get; set; } = 10;

        public static int Highest_Round { get; set; } = 0;
        public static int Highest_Zombies_Killed { get; set; } = 0;
        public static int Highest_PowerUps_PickedUp { get; set; } = 0;
        public static int Highest_Gold_Earned { get; set; } = 0;

        public static int Last_Round { get; set; } = 0;
        public static int Last_Zombies_Killed { get; set; } = 0;
        public static int Last_PowerUps_PickedUp { get; set; } = 0;
        public static int Last_Gold_Earned { get; set; } = 0;

        //Method for saving players stats to preferences
        public static void Save_Locally()
        {
            Preferences.Set(nameof(Gold), Gold);

            Preferences.Set(nameof(Bullet_Damage), Bullet_Damage);
            Preferences.Set(nameof(Bullet_Speed), Bullet_Speed);
            Preferences.Set(nameof(Mag_Capacity), Mag_Capacity);

            Preferences.Set(nameof(Highest_Round), Highest_Round);
            Preferences.Set(nameof(Highest_Zombies_Killed), Highest_Zombies_Killed);
            Preferences.Set(nameof(Highest_PowerUps_PickedUp), Highest_PowerUps_PickedUp);
            Preferences.Set(nameof(Highest_Gold_Earned), Highest_Gold_Earned);

            Preferences.Set(nameof(Last_Round), Last_Round);
            Preferences.Set(nameof(Last_Zombies_Killed), Last_Zombies_Killed);
            Preferences.Set(nameof(Last_PowerUps_PickedUp), Last_PowerUps_PickedUp);
            Preferences.Set(nameof(Last_Gold_Earned), Last_Gold_Earned);
        }

        //Method for loading players stats from preferences
        public static void Load_Locally()
        {
            Gold = Preferences.Get(nameof(Gold), 0);

            Bullet_Damage = Preferences.Get(nameof(Bullet_Damage), 20);
            Bullet_Speed = Preferences.Get(nameof(Bullet_Speed), 5);
            Mag_Capacity = Preferences.Get(nameof(Mag_Capacity), 10);

            Highest_Round = Preferences.Get(nameof(Highest_Round), 0);
            Highest_Zombies_Killed = Preferences.Get(nameof(Highest_Zombies_Killed), 0);
            Highest_PowerUps_PickedUp = Preferences.Get(nameof(Highest_PowerUps_PickedUp), 0);
            Highest_Gold_Earned = Preferences.Get(nameof(Highest_Gold_Earned), 0);

            Last_Round = Preferences.Get(nameof(Last_Round), 0);
            Last_Zombies_Killed = Preferences.Get(nameof(Last_Zombies_Killed), 0);
            Last_PowerUps_PickedUp = Preferences.Get(nameof(Last_PowerUps_PickedUp), 0);
            Last_Gold_Earned = Preferences.Get(nameof(Last_Gold_Earned), 0);
        }
    }
}
