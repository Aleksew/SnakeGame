using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(120, 50);
            Console.SetWindowSize(120, 50);

            new HorizontalLine(0, 120, 0, '%').Draw();
            new HorizontalLine(0, 120, 49, '%').Draw();
            new VerticalLine(0, 49, 0, '%').Draw();
            new VerticalLine(0, 49, 119, '%').Draw();

            Snake snake = new Snake(new Point(59, 24, '#'), 4, Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                snake.Move();
                Thread.Sleep(300);
            }



            Console.ReadKey();
        }
    }
}
