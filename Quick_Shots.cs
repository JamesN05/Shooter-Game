using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Quick_Shots
    {
        //Creating Image for Quick Shots
        public Image QuickShots_Img { get; private set; }

        public Quick_Shots()
        {
            //Setting outlines for the quick shots image
            QuickShots_Img = new Image
            {
                Source = "quick_shots.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
