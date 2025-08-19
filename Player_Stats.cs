using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Player_Stats
    {
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
    }
}
