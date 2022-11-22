namespace Triangle
{
    using System;
    public abstract class Triangle : Shape
    {
        private int length;

        public Triangle(int length, ConsolePoint origin, ConsoleColor color)
        {
            this.length = length;
            this.Origin = origin;
            this.Color = color;
        }

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }
    }
}