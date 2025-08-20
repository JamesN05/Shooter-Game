using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Nuke
    {
        //Creating Image for Nuke
        public Image Nuke_Img { get; private set; }

        public Nuke()
        {
            //Setting outlines for the nuke image
            Nuke_Img = new Image
            {
                Source = "nuke.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
