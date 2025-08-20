using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    class Instakill
    {
        //Creating Image for Instakill
        public Image Instakill_Img {  get; private set; }

        public Instakill()
        {
            //Setting outlines for the instakill image
            Instakill_Img = new Image
            {
                Source = "instakill.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
