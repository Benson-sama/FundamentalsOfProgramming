namespace Triangle
{
    using System;
    public class Diamond : Shape
    {
        private int size;

        public Diamond(int size, ConsolePoint origin, ConsoleColor color)
        {
            this.size = size;
            this.Origin = origin;
            this.Color = color;
        }
        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > 0)
                {
                    this.size = value;
                }
            }
        }
    }
}