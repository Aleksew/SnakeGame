using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Snake
{
    public class GameMenu
    {
        //•	Выбор режима игры (змейка проходит сквозь стены или нет, начальная скорость, какие виды еды доступны). 
        ConsoleColor itemColor = ConsoleColor.Blue;
        ConsoleColor selectionColor = ConsoleColor.Cyan;

        int selectedItem { get; set; }
        int menuLeft = 10;
        int menuTop = 10;

        public delegate void MenuMethod();
        public List<MenuMethod> Methods;


        public GameMenu(params MenuMethod[] menuMethods)
        {
            Methods = new List<MenuMethod>();
            Methods.AddRange(menuMethods);
        }

        private void UserIntput()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Q:
                    ExitProgramm();
                    break;
                case ConsoleKey.Enter:
                    Methods[selectedItem]();
                    ShowMenu();
                    break;
                case ConsoleKey.LeftArrow:
                    ChangeItemLeft();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.RightArrow:
                    ChangeItemRight();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }

        public void ShowMenu()
        {
            UserIntput();
        }

        private void MoveDown()
        {
            Debug.WriteLine($"Нажата кнопка вниз");
            ShowMenu();
        }

        private void ChangeItemRight()
        {
            Debug.WriteLine($"Нажата кнопка вправо");
            ShowMenu();
        }

        private void MoveUp()
        {
            Debug.WriteLine($"Нажата кнопка вверх");
            ShowMenu();
        }

        private void ChangeItemLeft()
        {
            Debug.WriteLine($"Нажата кнопка влево");
            ShowMenu();
        }

        private void ExitProgramm()
        {
            Environment.Exit(-1);
        }
    }
}
