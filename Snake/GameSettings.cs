using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class GameSettings
    {
        const int width = 120;
        const int height = 50;

        public GameSettings()
        {
            SetSetting();
        }


        public void SetSetting()

        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height);


            new HorizontalLine(0, width, 0, '%').Draw();
            new HorizontalLine(0, width, height - 1, '%').Draw();
            new VerticalLine(0, height - 1, 0, '%').Draw();
            new VerticalLine(0, height - 1, width - 1, '%').Draw();
        }
    }
}
