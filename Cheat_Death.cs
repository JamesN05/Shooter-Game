using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Cheat_Death
    {
        //Creating Image for Cheat Death
        public Image CheatDeath_Img { get; private set; }

        public Cheat_Death()
        {
            //Setting outlines for the cheat death image
            CheatDeath_Img = new Image
            {
                Source = "cheat_death.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
