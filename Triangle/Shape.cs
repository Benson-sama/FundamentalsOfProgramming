namespace Triangle
{
    using System;
    public abstract class Shape
    {
        private ConsolePoint origin;
        private ConsoleColor color;

        public Shape()
        {
            this.origin = new ConsolePoint();
        }

        public System.ConsoleColor Color
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
                origin.Left = value.Left;
                origin.Top = value.Top;
            }
        }
    }
}