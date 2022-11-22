namespace DiscountSnake
{
    using System;

    public class Renderer
    {
        public void Draw(PlayFigure playFigure)
        {
            Console.SetCursorPosition(playFigure.Origin.Left, playFigure.Origin.Top);
            Console.Write(playFigure.HeadCharacter);
        }

        public void Clear(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(" ");
        }
    }
}