namespace DiscountSnake
{
    using System;

    public class ConsolePoint
    {
        public event EventHandler<OriginChangedEventArgs> OriginChanged;
        private int left;
        private int top;

        public int Left
        {
            get
            {
                return this.left;
            }
            set
            {
                int previousLeft = this.left;
                this.left = value;

                if (OriginChanged != null)
                {
                    FireOriginChanged(previousLeft, this.Top);
                }
            }
        }

        public int Top
        {
            get
            {
                return this.top;
            }
            set
            {
                int previousTop = this.top;
                this.top = value;

                if (OriginChanged != null)
                {
                    FireOriginChanged(this.Left, previousTop);
                }
            }
        }

        private void FireOriginChanged(int previousLeft, int previousTop)
        {
            OriginChangedEventArgs originChangedEventArgs = new OriginChangedEventArgs();
            originChangedEventArgs.PreviousLeft = previousLeft;
            originChangedEventArgs.PreviousTop = previousTop;
            originChangedEventArgs.Left = this.Left;
            originChangedEventArgs.Top = this.Top;

            this.OriginChanged(this, originChangedEventArgs);
        }
    }
}