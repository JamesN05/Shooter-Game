using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Instakill
    {
        public Image Instakill_Img {  get; private set; }

        public Instakill()
        {
            Instakill_Img = new Image
            {
                Source = "instakill.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
