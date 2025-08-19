using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Free_Fire
    {
        public Image FreeFire_Img { get; private set; }

        public Free_Fire()
        {
            FreeFire_Img = new Image
            {
                Source = "free_fire.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
