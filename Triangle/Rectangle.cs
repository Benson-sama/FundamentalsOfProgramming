namespace Triangle
{
    using System;
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int height, int width, ConsolePoint origin, ConsoleColor color)
        {
            this.Height = height;
            this.Width = width;
            this.Origin = origin;
            this.Color = color;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }
    }
}