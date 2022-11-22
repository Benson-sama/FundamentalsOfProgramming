namespace Triangle
{
    using System;
    public class Renderer
    {
        public void Draw(Rectangle rectangle)
        {
            Console.BackgroundColor = rectangle.Color;
            for (int i = 0; i < rectangle.Height; i++)
            {
                for (int j = 0; j < rectangle.Width; j++)
                {
                    Console.SetCursorPosition(rectangle.Origin.Left + j, rectangle.Origin.Top + i);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }

        public void Draw(RightTopOpenTriangle triangle)
        {
            Console.BackgroundColor = triangle.Color;
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.SetCursorPosition(triangle.Origin.Left + col, triangle.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }

        public void Draw(LeftTopOpenTriangle triangle)
        {
            Console.BackgroundColor = triangle.Color;
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = triangle.Length; col >= triangle.Length - row; col--)
                {
                    Console.SetCursorPosition(triangle.Origin.Left + col, triangle.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }

        public void Draw(RightBottomOpenTriangle triangle)
        {
            Console.BackgroundColor = triangle.Color;
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = 0; col < triangle.Length - row; col++)
                {
                    Console.SetCursorPosition(triangle.Origin.Left + col, triangle.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }

        public void Draw(LeftBottomOpenTriangle triangle)
        {
            Console.BackgroundColor = triangle.Color;
            for (int row = 0; row < triangle.Length; row++)
            {
                for (int col = triangle.Length; col > row; col--)
                {
                    Console.SetCursorPosition(triangle.Origin.Left + col, triangle.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }

        public void Draw(Diamond diamond)
        {
            Console.BackgroundColor = diamond.Color;
            for (int row = 0; row < diamond.Size/2; row++)
            {
                for (int col = diamond.Size / 2; col >= diamond.Size / 2 - row; col--)
                {
                    Console.SetCursorPosition(diamond.Origin.Left + col, diamond.Origin.Top + row);
                    Console.Write(" ");
                }
                for (int col = diamond.Size / 2; col <= diamond.Size / 2 + row; col++)
                {
                    Console.SetCursorPosition(diamond.Origin.Left + col, diamond.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            for (int row = diamond.Size / 2; row < diamond.Size; row++)
            {
                for (int col = diamond.Size / 2; col > row - diamond.Size / 2; col--)
                {
                    Console.SetCursorPosition(diamond.Origin.Left + col, diamond.Origin.Top + row);
                    Console.Write(" ");
                }

                for (int col = diamond.Size / 2; col < diamond.Size + (diamond.Size / 2) - row; col++)
                {
                    Console.SetCursorPosition(diamond.Origin.Left + col, diamond.Origin.Top + row);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }
    }
}
/*
  X
 XXX
XXXXX
 XXX
  X
*/