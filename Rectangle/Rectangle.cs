using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private int height;
        private int width;
        private ConsoleColor color;
        private ConsolePoint origin;

        public Rectangle(int left, int top, int height, int width, ConsoleColor Color)
        {
            this.height = height;
            this.width = width;
            this.Color = Color;
            this.origin = new ConsolePoint();
            this.origin.Left = left;
            this.origin.Top = top;

        }
        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public int Position
        {
            get
            {
                return this.Position;
            }
            private set
            {
                this.Position = value;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public ConsolePoint Origin
        {
            get
            {
                return origin;
            }
            set
            {
                Origin.Left = value.Left;
                Origin.Top = value.Top;
            }
        }
        public void PrintRectangle()
        {
            Console.BackgroundColor = Color;

            for (int i = origin.Left; i < origin.Left+width; i++)
            {
                for (int j = origin.Top; j < origin.Top+height; j++)
                {
                    if(i>=Console.WindowWidth || j>=Console.WindowHeight)
                        continue;
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(" ");
                }
            }
            Console.ResetColor();
        }
    }
}