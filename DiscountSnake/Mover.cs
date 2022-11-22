namespace DiscountSnake
{
    public class Mover : IMover
    {
        private int windowWidth;
        private int windowHeight;

        public Mover(int windowWidth, int windowHeight)
        {
            this.windowWidth = windowWidth;
            this.windowHeight = windowHeight;
        }

        public void MoveLeft(PlayFigure playFigure)
        {
            if (playFigure.Origin.Left > 0)
            {
                playFigure.Origin.Left--;
            }
        }

        public void MoveRight(PlayFigure playFigure)
        {
            if (playFigure.Origin.Left < this.windowWidth - 1)
            {
                playFigure.Origin.Left++;
            }
        }

        public void MoveUp(PlayFigure playFigure)
        {
            if (playFigure.Origin.Top > 0)
            {
                playFigure.Origin.Top--;
            }
        }

        public void MoveDown(PlayFigure playFigure)
        {
            // Additionally restrict movement to the last row of the console.
            if (playFigure.Origin.Top < this.windowHeight - 2)
            {
                playFigure.Origin.Top++;
            }
        }
    }
}