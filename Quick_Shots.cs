using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Quick_Shots
    {
        public Image QuickShots_Img { get; private set; }

        public Quick_Shots()
        {
            QuickShots_Img = new Image
            {
                Source = "quick_shots.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
