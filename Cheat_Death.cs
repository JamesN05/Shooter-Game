using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Cheat_Death
    {
        public Image CheatDeath_Img { get; private set; }

        public Cheat_Death()
        {
            CheatDeath_Img = new Image
            {
                Source = "cheat_death.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
