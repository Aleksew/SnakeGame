
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Figure
    {
      protected  List<Point> pointList;

        public void Draw()
        {
            foreach (var point in pointList)
            {
                point.Draw();
            }
        }
    }
}
