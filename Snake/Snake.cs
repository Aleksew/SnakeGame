using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point point, int lengh, Direction direction)
        {
            pointList = new List<Point>();
            this.direction = direction;
            for (int i = 0; i < lengh; i++)
            {
                var p = new Point(point);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        public void Move()
        {
            Point tailPoint = pointList.First();
            pointList.Remove(tailPoint);
            Point headPoint = GetNextPoint();
            pointList.Add(headPoint);

            tailPoint.Clear();
            headPoint.Draw();
        }

        public Point GetNextPoint()
        {
            var headpoint = pointList.Last();
            var nextPoint = new Point(headpoint);
            nextPoint.Move(1, direction);


            return nextPoint;
        }
    }
}
