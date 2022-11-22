namespace DiscountSnake
{
    using System;

    public class OnPressedKeyEventArgs : EventArgs
    {
        private ConsoleKeyInfo consoleKeyInfo;

        public OnPressedKeyEventArgs(ConsoleKeyInfo consoleKeyInfo)
        {
            this.consoleKeyInfo = consoleKeyInfo;
        }

        public ConsoleKey Key
        {
            get
            {
                return this.consoleKeyInfo.Key; 
            }
        }
    }
}