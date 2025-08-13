using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Shooter_Game
{
    internal class Bullet
    {
        public Image Bullet_Img { get; private set; }

        public Bullet()
        {
            Bullet_Img = new Image
            {
                Source = "bullet.png",
                HeightRequest = 20,
                WidthRequest = 20
            };
        }
    }
}
