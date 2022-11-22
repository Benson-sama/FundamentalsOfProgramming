using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            SetSpecificConsoleSettings("Rectangle", false);
            ConsoleColor ActiveColor = ConsoleColor.Green;
            System.Random random = new Random();

            while (true)
            {
                int randomHeight = random.Next(1, 15);
                int randomWidth = random.Next(1, 30);
                int randomLeft = random.Next(0, Console.WindowWidth);
                int randomTop = random.Next(0, Console.WindowHeight);

                PrintCurrentColorStatus(ActiveColor);

                Rectangle Rectangle = new Rectangle(randomLeft, randomTop, randomHeight, randomWidth, ActiveColor);

                ConsoleKeyInfo NextKeyPressed = Console.ReadKey();
                switch (NextKeyPressed.Key)
                {
                    case ConsoleKey.F1:
                        Rectangle.PrintRectangle();
                        break;
                    case ConsoleKey.F2:
                        ActiveColor = GetNextColor(ActiveColor);
                        break;
                    case ConsoleKey.Delete:
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
                Console.SetCursorPosition(0, 0);
            }
        }
        private static void SetSpecificConsoleSettings(string title, bool isCursorVisible)
        {
            Console.Title = title;
            Console.CursorVisible = isCursorVisible;
        }
        private static ConsoleColor GetNextColor(ConsoleColor Color)
        {
            switch (Color)
            {
                case ConsoleColor.Black:
                    Color = ConsoleColor.DarkBlue;
                    break;
                case ConsoleColor.DarkBlue:
                    Color = ConsoleColor.DarkGreen;
                    break;
                case ConsoleColor.DarkGreen:
                    Color = ConsoleColor.DarkCyan;
                    break;
                case ConsoleColor.DarkCyan:
                    Color = ConsoleColor.DarkRed;
                    break;
                case ConsoleColor.DarkRed:
                    Color = ConsoleColor.DarkMagenta;
                    break;
                case ConsoleColor.DarkMagenta:
                    Color = ConsoleColor.DarkYellow;
                    break;
                case ConsoleColor.DarkYellow:
                    Color = ConsoleColor.Gray;
                    break;
                case ConsoleColor.Gray:
                    Color = ConsoleColor.DarkGray;
                    break;
                case ConsoleColor.DarkGray:
                    Color = ConsoleColor.Blue;
                    break;
                case ConsoleColor.Blue:
                    Color = ConsoleColor.Green;
                    break;
                case ConsoleColor.Green:
                    Color = ConsoleColor.Cyan;
                    break;
                case ConsoleColor.Cyan:
                    Color = ConsoleColor.Red;
                    break;
                case ConsoleColor.Red:
                    Color = ConsoleColor.Magenta;
                    break;
                case ConsoleColor.Magenta:
                    Color = ConsoleColor.Yellow;
                    break;
                case ConsoleColor.Yellow:
                    Color = ConsoleColor.Gray;
                    break;
                case ConsoleColor.White:
                    Color = ConsoleColor.Black;
                    break;
            }
            return Color;
        }
        private static void PrintCurrentColorStatus(ConsoleColor Color)
        {
            Console.SetCursorPosition(0, Console.WindowHeight-1);
            Console.ForegroundColor = Color;
            Console.WriteLine("Aktuelle Farbe");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
    }
}
