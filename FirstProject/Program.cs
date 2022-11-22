//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH Wiener Neustadt">
//     Copyright (c) FH Wiener Neustadt. All rights reserved.
// </copyright>
// <author>Benjamin Bogner</author>
// <summary>Contains Program</summary>
//-----------------------------------------------------------------------
namespace FirstProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            double firstNumber = 10.1;
            double secondNumber = 20.2;
            double result;

            result = firstNumber + secondNumber;

            Console.WriteLine($"Das Ergebnis von {firstNumber} + {secondNumber} = {result}.");

            Console.WriteLine("Bitte drücken Sie zum Beenden eine beliebige Taste!");
            Console.ReadKey();
        }
    }
}
