using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int leftX,int rightX, int y, char sym)
        {
            pointList = new List<Point>();

            for (int i = leftX; i < rightX; i++)
            {
                Point point = new Point(i, y, sym);
                pointList.Add(point);
            }

        }

    }
}
