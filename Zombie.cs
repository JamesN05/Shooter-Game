using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Shooter_Game
{
    class Zombie
    {
        public Image Zombie_Img { get; private set; }
        public int Zombie_Health { get; set; }
        
        public Zombie()
        {
            Zombie_Img = new Image
            {
                Source = "zombie.png",
                HeightRequest = 70,
                WidthRequest = 50
            };
        }
    }
}
