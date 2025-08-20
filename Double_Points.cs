using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    internal class Double_Points
    {
        //Creating Image for Double Points
        public Image DoublePoints_Img { get; private set; }

        public Double_Points()
        {
            //Setting outlines for the double points image
            DoublePoints_Img = new Image()
            {
                Source = "double_points.png",
                WidthRequest = 35,
                HeightRequest = 35
            };
        }
    }
}
