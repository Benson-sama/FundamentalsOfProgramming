using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            string op;

            firstNumber = ReadNumber("Bitte geben Sie die erste Zahl ein: ");
            secondNumber = ReadNumber("Bitte geben Sie die zweite Zahl ein: ");
            op = ReadOperator();
        }
        private static double ReadNumber(string prompt)
        {
            bool isValid;
            double number;

            do
            {
                Console.WriteLine(prompt);
                isValid = double.TryParse(Console.ReadLine(), out number);
                if(!isValid)
                    Console.WriteLine("Die Eingabe war inkorrekt!");
            } while (!isValid);

            return number;

        }
        private static string ReadOperator(string prompt)
        {
            bool isValid;
            string input;

            do
            {
                Console.WriteLine(prompt);
                isValid = double.TryParse(Console.ReadLine(), out input);
                if (!isValid)
                    Console.WriteLine("Die Eingabe war inkorrekt!");
            } while (!isValid);

            return input;
            
        }
    }
}
