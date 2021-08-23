using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int topY, int downY, int x, char sym)
        {
            pointList = new List<Point>();

            for (int i = topY; i < downY; i++)
            {
                Point point = new Point(x, i, sym);
                pointList.Add(point);
            }
        }
    }
}