//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH Wiener Neustadt">
//     Copyright (c) FH Wiener Neustadt. All rights reserved.
// </copyright>
// <author>Benjamin Bogner</author>
// <summary>Contains Program</summary>
//-----------------------------------------------------------------------
namespace Lotto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the Program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Represents the entry point of the application.
        /// </summary>
        /// <param name="args">Specified command line arguments.</param>
        static void Main(string[] args)
        {
            Random random = new System.Random();
            int lottoRange;
            int amountOfLottoDraws;
            int[] numberOfResults = new int[3];
            int lotteryResult;
            bool IsLottoJackpotFound = false;
            bool IsBonusBallMatching;
            double counterUntilJackpotFound = 0;
            while (!IsLottoJackpotFound)
            {
                int[] LotteryTestTicket = GetLotteryDraw(6, 45, random);
                int[] LotteryTestDraw = GetLotteryDraw(6, 45, random);
                lotteryResult = GetLotteryResults(LotteryTestTicket, LotteryTestDraw, out IsBonusBallMatching);
                switch (lotteryResult)
                {
                    case 3:
                        numberOfResults[0]++;
                        break;
                    case 4:
                        numberOfResults[1]++;
                        break;
                    case 5:
                        numberOfResults[2]++;
                        break;
                    case 6:
                        IsLottoJackpotFound = true;
                        Console.WriteLine($"Der Lotto Sechser mit dem Wert: {lotteryResult} wurde nach {counterUntilJackpotFound} Ziehungen gefunden.");
                        Console.WriteLine($"Die Anzahl der 3er beträgt: {numberOfResults[0]}");
                        Console.WriteLine($"Die Anzahl der 4er beträgt: {numberOfResults[1]}");
                        Console.WriteLine($"Die Anzahl der 5er beträgt: {numberOfResults[2]}");
                        break;
                    default:
                        break;
                }

                counterUntilJackpotFound++;
            }
            


            bool isActive = true;
            // bool IsBonusBallMatching;
            while (isActive)
            {
                Console.WriteLine("\n\nWelches Format soll das Lotto-Spiel haben?");
                Console.WriteLine("Bitte geben Sie die Anzahl der Tipps ein!");
                amountOfLottoDraws = int.Parse(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie einen Zahlenbereich für die Ziehung ein! (Anzahl der möglichen Zahlen auf dem Lottoschein)");
                lottoRange = int.Parse(Console.ReadLine());
                int[] lotteryTicket = GetLotteryTicket(amountOfLottoDraws, lottoRange);
                int[] lotteryDraw = GetLotteryDraw(amountOfLottoDraws, lottoRange, random);
                Console.WriteLine($"Ihre Ziehung ergab den Wert: {GetLotteryResults(lotteryTicket, lotteryDraw, out IsBonusBallMatching)}");
                if (IsBonusBallMatching)
                {
                    Console.WriteLine("Die Zusatzzahl wurde getroffen!");
                }
                else
                {
                    Console.WriteLine("Die Zusatzzahl wurde nicht getroffen!");
                }
                Console.WriteLine("Möchten Sie erneut spielen? Geben Sie 'JA' ein um erneut zu spielen!");
                
                if (Console.ReadLine() != "JA")
                {
                    isActive = false;
                }
            }

            Console.WriteLine("Vielen Dank für Ihre Teilnahme.");
            Console.ReadKey();
        }

        /// <summary>
        /// Let's the user input his ticket.
        /// </summary>
        /// <returns>
        /// An array with the given inputs.
        /// </returns>
        public static int[] GetLotteryTicket(int numberOfDraws, int range)
        {
            int[] input = new int[numberOfDraws];
            bool isValid;
            bool isDuplicate;
            int currentInput;
            Console.WriteLine($"Bitte geben Sie Ihre {numberOfDraws} Zahlen ohne Duplikate für die Ziehung ein!");
            for (int i = 0; i < numberOfDraws; i++)
            {
                do
                {
                    Console.WriteLine($"Bitte geben Sie die {i+1}. Zahl ein: ");
                    isValid = int.TryParse(Console.ReadLine(), out currentInput);
                    isDuplicate = CheckForDuplicate(input, currentInput);
                    if (isDuplicate || !isValid || currentInput < 1 || currentInput > range)
                    {
                        Console.WriteLine("Es handelt sich um ein Duplikat oder um eine Zahl außerhalb der Grenzen, derzeit noch nicht definiert!");
                        isValid = false;
                    }
                    else
                    {
                        input[i] = currentInput;
                    }
                } 
                while (!isValid);
            }

            return input;
        }

        /// <summary>
        /// Draws random numbers without duplicates into an array.
        /// </summary>
        /// <returns>
        /// An array with random numbers.
        /// </returns>
        public static int[] GetLotteryDraw(int numberOfDraws, int range, Random random)
        {
            int[] input = new int[numberOfDraws+1];
            bool isDuplicate;
            int currentNumber;
            for (int i = 0; i < numberOfDraws+1; i++)
            {
                while (true)
                {
                    currentNumber = random.Next(1, range);
                    isDuplicate = CheckForDuplicate(input, currentNumber);
                    if (isDuplicate)
                    {
                        continue;
                    }
                    if (!isDuplicate)
                    {
                        input[i] = currentNumber;
                        break;
                    }
                }
            }

            return input;
        }

        /// <summary>
        /// Checks a specific array for duplicates.
        /// </summary>
        /// <returns>
        /// True if a duplicate is found.
        /// </returns>
        /// <param name="array">Array, that has to be checked.</param>
        /// <param name="value">Value, that has to be searched.</param>
        public static bool CheckForDuplicate(int[] array, int value)
        {
            bool isDuplicate = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0 && array[i] == value)
                {
                    isDuplicate = true;
                }
            }

            return isDuplicate;
        }

        /// <summary>
        /// Compares every value of one array with every value of another array.
        /// </summary>
        /// <returns>
        /// The number of matched items.
        /// </returns>
        /// <param name="ticket">Second Array.</param>
        /// <param name="draw">First array.</param>
        public static int GetLotteryResults(int[] ticket, int[] draw, out bool IsBonusBallMatching)
        {
            IsBonusBallMatching = false;
            int result = 0;
            for (int i = 0; i < ticket.Length; i++)
            {
                for (int j = 0; j < draw.Length-1; j++)
                {
                    if (ticket[i] == draw[j])
                    {
                        result++;
                    }
                }
                if (ticket[i] == draw[draw.Length-1])
                {
                    IsBonusBallMatching = true;
                }
            }
            return result;
        }
    }
}