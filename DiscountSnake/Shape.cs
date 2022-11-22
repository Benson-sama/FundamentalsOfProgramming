using System;

namespace DiscountSnake
{
    public abstract class Shape : IMovable
    {
        public event EventHandler<PositionChangedEventArgs> PositionChanged;
        private ConsolePoint origin;

        public Shape(int left, int top)
        {
            this.origin = new ConsolePoint();
            this.Origin.OriginChanged += FirePositionChanged;
            this.Origin.Left = left;
            this.Origin.Top = top;
        }

        private void FirePositionChanged(object sender, OriginChangedEventArgs e)
        {
            PositionChangedEventArgs positionChangedEventArgs = new PositionChangedEventArgs();
            positionChangedEventArgs.PreviousLeft = e.PreviousLeft;
            positionChangedEventArgs.PreviousTop = e.PreviousTop;
            positionChangedEventArgs.Left = e.Left;
            positionChangedEventArgs.Top = e.Top;

            if (this.PositionChanged != null)
            {
                this.PositionChanged(this, positionChangedEventArgs);
            }
        }

        public ConsolePoint Origin
        {
            get
            {
                return this.origin;
            }
            set
            {
                this.origin = value;
            }
        }
    }
}