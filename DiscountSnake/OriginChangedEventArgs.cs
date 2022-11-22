namespace DiscountSnake
{
    using System;

    public class OriginChangedEventArgs : EventArgs
    {
        public int PreviousLeft
        {
            get;
            set;
        }

        public int PreviousTop
        {
            get;
            set;
        }

        public int Left
        {
            get;
            set;
        }

        public int Top
        {
            get;
            set;
        }
    }
}