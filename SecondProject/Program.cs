//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH Wiener Neustadt">
//     Copyright (c) FH Wiener Neustadt. All rights reserved.
// </copyright>
// <author>Benjamin Bogner</author>
// <summary>Contains Program</summary>
//-----------------------------------------------------------------------
namespace SecondProject
{
    using System;

    /// <summary>
    /// Represents the Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Represents the entry point of the application.
        /// </summary>
        /// <param name="args">Specified command line arguments.</param>
        public static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double result = 0;
            bool isValid;
            string op;            // Operator

            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            isValid = double.TryParse(Console.ReadLine(), out firstNumber);

            if (!isValid)
            {
                Console.Write("Bitte geben Sie eine gültige Zahl ein!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Bitte geben Sie die nächste Zahl ein:");
            isValid = double.TryParse(Console.ReadLine(), out secondNumber);

            if (!isValid)
            {
                Console.WriteLine("Bitte geben Sie eine gültige Zahl ein!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Bitte geben Sie einen Operator ein! (+, -, *, /");
            op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    try
                    {
                        result = (firstNumber / secondNumber);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Fehler: Man kann nicht durch 0 teilen!");
                    }
                    break;
                    // default:
            }
            Console.WriteLine($"Das Ergebnis von {firstNumber} + {secondNumber} = {result}.");
            Console.WriteLine("Bitte drücken Sie zum Beenden eine beliebige Taste!");
            Console.ReadKey();
        }


    }

}

