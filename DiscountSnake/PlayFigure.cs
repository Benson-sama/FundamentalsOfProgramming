namespace DiscountSnake
{
    public class PlayFigure : Shape
    {
        private char headCharacter;

        public PlayFigure(int left, int top, char headCharacter) : base(left, top)
        {
            this.headCharacter = headCharacter;
        }

        public char HeadCharacter
        {
            get
            {
                return this.headCharacter;
            }
            private set
            {
                this.headCharacter = value;
            }
        }
    }
}