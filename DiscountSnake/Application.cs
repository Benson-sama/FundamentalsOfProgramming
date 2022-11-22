namespace DiscountSnake
{
    using System;

    public class Application
    {
        private PlayFigure playFigure;
        private KeyboardWatcher bigBrother;
        private Mover wolfgangAmadeusMovezart;
        private Renderer renderer;

        public Application()
        {
            // Initialize playFigure with random coordinates.
            Random random = new Random();
            int randomLeft = random.Next(0, Console.WindowWidth);
            int randomTop = random.Next(0, Console.WindowHeight - 1);
            this.playFigure = new PlayFigure(randomLeft, randomTop, '+');
            this.playFigure.PositionChanged += FigurePositionChanged;
            this.renderer = new Renderer();

            this.bigBrother = new KeyboardWatcher();
            bigBrother.OnPressedKey += ExecuteKeyPressedCommand;
            this.wolfgangAmadeusMovezart = new Mover(Console.WindowWidth, Console.WindowHeight);
        }

        public void Run()
        {
            Console.CursorVisible = false;

            this.renderer.Draw(this.playFigure);
            bigBrother.Start();
        }

        private void FigurePositionChanged(object sender, PositionChangedEventArgs e)
        {
            this.renderer.Clear(e.PreviousLeft, e.PreviousTop);
            this.renderer.Draw(this.playFigure);
        }

        private void ExecuteKeyPressedCommand(object sender, OnPressedKeyEventArgs args)
        {
            switch (args.Key)
            {
                case ConsoleKey.LeftArrow:
                    this.wolfgangAmadeusMovezart.MoveLeft(this.playFigure);
                    break;
                case ConsoleKey.UpArrow:
                    this.wolfgangAmadeusMovezart.MoveUp(this.playFigure);
                    break;
                case ConsoleKey.RightArrow:
                    this.wolfgangAmadeusMovezart.MoveRight(this.playFigure);
                    break;
                case ConsoleKey.DownArrow:
                    this.wolfgangAmadeusMovezart.MoveDown(this.playFigure);
                    break;
                default:
                    break;
            }
        }
    }
}