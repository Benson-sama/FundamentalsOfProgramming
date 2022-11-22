namespace Triangle
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsolePoint randomOrigin = new ConsolePoint();
            ConsoleKeyInfo keyInput = new ConsoleKeyInfo();
            Renderer renderer = new Renderer();
            Random random = new Random();
            ConsoleColor activeColor = new ConsoleColor();
            activeColor = ConsoleColor.Green;
            bool isActive = true;
            while (isActive)
            {
                PrintCurrentColorStatus(activeColor);
                randomOrigin = GetRandomOrigin(random);
                keyInput = Console.ReadKey(true);
                switch (keyInput.Key)
                {
                    case ConsoleKey.F1:
                        Rectangle rectangle = new Rectangle(5, 10, randomOrigin, activeColor);
                        renderer.Draw(rectangle);
                        break;
                    case ConsoleKey.F2:
                        RightTopOpenTriangle rightTopOpenTriangle = new RightTopOpenTriangle(3, randomOrigin, activeColor);
                        renderer.Draw(rightTopOpenTriangle);
                        break;
                    case ConsoleKey.F3:
                        LeftTopOpenTriangle leftTopOpenTriangle = new LeftTopOpenTriangle(3, randomOrigin, activeColor);
                        renderer.Draw(leftTopOpenTriangle);
                        break;
                    case ConsoleKey.F4:
                        RightBottomOpenTriangle rightBottomOpenTriangle = new RightBottomOpenTriangle(3, randomOrigin, activeColor);
                        renderer.Draw(rightBottomOpenTriangle);
                        break;
                    case ConsoleKey.F5:
                        LeftBottomOpenTriangle leftBottomOpenTriangle = new LeftBottomOpenTriangle(3, randomOrigin, activeColor);
                        renderer.Draw(leftBottomOpenTriangle);
                        break;
                    case ConsoleKey.F6:
                        Diamond diamond = new Diamond(8, randomOrigin, activeColor);
                        renderer.Draw(diamond);
                        break;
                    case ConsoleKey.F12:
                        activeColor = GetNextColor(activeColor);
                        break;
                    case ConsoleKey.Delete:
                        Console.Clear();
                        break;
                    case ConsoleKey.Escape:
                        isActive = false;
                        break;
                }
            }
        }

        private static ConsolePoint GetRandomOrigin(Random random)
        {
            ConsolePoint origin = new ConsolePoint();
            origin.Left = random.Next(0, 101);
            origin.Top = random.Next(0, 21);

            return origin;
        }

        private static ConsoleColor GetNextColor(ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    color = ConsoleColor.DarkBlue;
                    break;
                case ConsoleColor.DarkBlue:
                    color = ConsoleColor.DarkGreen;
                    break;
                case ConsoleColor.DarkGreen:
                    color = ConsoleColor.DarkCyan;
                    break;
                case ConsoleColor.DarkCyan:
                    color = ConsoleColor.DarkRed;
                    break;
                case ConsoleColor.DarkRed:
                    color = ConsoleColor.DarkMagenta;
                    break;
                case ConsoleColor.DarkMagenta:
                    color = ConsoleColor.DarkYellow;
                    break;
                case ConsoleColor.DarkYellow:
                    color = ConsoleColor.Gray;
                    break;
                case ConsoleColor.Gray:
                    color = ConsoleColor.DarkGray;
                    break;
                case ConsoleColor.DarkGray:
                    color = ConsoleColor.Magenta;
                    break;
                case ConsoleColor.Blue:
                    color = ConsoleColor.Green;
                    break;
                case ConsoleColor.Green:
                    color = ConsoleColor.Cyan;
                    break;
                case ConsoleColor.Cyan:
                    color = ConsoleColor.Red;
                    break;
                case ConsoleColor.Red:
                    color = ConsoleColor.Blue;
                    break;
                case ConsoleColor.Magenta:
                    color = ConsoleColor.Yellow;
                    break;
                case ConsoleColor.Yellow:
                    color = ConsoleColor.White;
                    break;
                case ConsoleColor.White:
                    color = ConsoleColor.Black;
                    break;
            }
            return color;
        }

        private static void PrintCurrentColorStatus(ConsoleColor color)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = color;
            Console.WriteLine("Aktuelle Farbe");
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
    }
}