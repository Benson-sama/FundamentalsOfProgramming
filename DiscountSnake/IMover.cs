namespace DiscountSnake
{
    public interface IMover
    {
        void MoveLeft(PlayFigure playFigure);

        void MoveRight(PlayFigure playFigure);

        void MoveUp(PlayFigure playFigure);

        void MoveDown(PlayFigure playFigure);
    }
}