using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Point
    {
        int x;
        int y;
        char sym;
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.RIGHT:
                    x = x + offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
                case Direction.UP:
                    y = y + offset;
                    break;

            }
        }

        internal void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
