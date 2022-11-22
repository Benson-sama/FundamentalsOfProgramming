namespace DiscountSnake
{
    using System;

    public class KeyboardWatcher
    {
        public event EventHandler<OnPressedKeyEventArgs> OnPressedKey;

        public void Start()
        {
            while (true)
            {
                if (!Console.KeyAvailable)
                {
                    continue;
                }

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                OnPressedKeyEventArgs onPressedKeyEventArgs = new OnPressedKeyEventArgs(consoleKeyInfo);

                if (OnPressedKey != null)
                {
                    this.OnPressedKey(this, onPressedKeyEventArgs);
                }
            }
        }
    }
}