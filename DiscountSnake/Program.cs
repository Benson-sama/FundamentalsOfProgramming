namespace DiscountSnake
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Application application = new Application();
            application.Run();
        }
    }
}
