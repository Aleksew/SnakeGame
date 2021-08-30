using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            var cm = new GameMenu();
            cm.ShowMenu();
            new GameSettings();


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
