using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)     // Argumente in folgendem Format: Zeile, Spalte, Zahl, ... , Zeile, Spalte, Zahl;
        {
            Console.SetWindowSize(25, 15);
            // string[] commandLineArguments = args;

            // Überprüfen der CLI-Argumente auf Korrektheit
            bool isValid;
            isValid = IsNumberOfArgumentsPowerOfValue(args, 3);
            // Konvertieren der CLI-Argumente in ein Int-Array
            int[] commandLineArgumentsAsInt;
            ConvertStringArrayToIntArray(args, out commandLineArgumentsAsInt);
            // Erstellen des 9x9 Sudokus
            int[,] sudoku = GenerateSudokuWithArguments(commandLineArgumentsAsInt);
            // Auszug eines Blockes aus dem Sudoku (eindimensionales Array)
            // [1][2][3]
            // [4][5][6]
            // [7][8][9]
            int[] firstBlockOfSudoku = GetSpecificBlockFromSudoku(sudoku, 1);
            // Contains

            PrintSudoku(sudoku);
            int[] input = GetSudokuInput();
            SetSudokuInput(sudoku, input);
            Console.ReadLine();
        }

        private static void SetSudokuInput(int[,] sudoku, int[] input)
        {
            int row = input[0];
            int column = input[1];
            int value = input[2];
            sudoku[row - 1, column - 1] = value;
            Console.Clear();
            PrintSudoku(sudoku);
        }

        private static int[] GetSudokuInput()
        {
            int[] array = new int[3];
            Console.WriteLine("Bitte geben Sie eine Zeile, eine Spalte und eine Zahl ein! (Beachten Sie die Formatierungsregeln!)");
            for (int i = 0; i < 3; i++)
            {
                // ohne Fehlerbehandlung
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        private static void ConvertStringArrayToIntArray(string[] stringArray, out int[] intArray)
        {
            intArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                try
                {
                    intArray[i] = Convert.ToInt32(stringArray[i]);
                }
                catch (FormatException)
                {
                    Console.SetWindowSize(100, 25);
                    Console.WriteLine("Ein angegebener Wert ist nicht im richtigen Format. Bitte geben Sie nur Zahlen ein!");
                }
            }
        }

        private static bool IsNumberOfArgumentsPowerOfValue(string[] arguments, int value)
        {
            bool isValid;

            isValid = arguments.Length % value == 0;
            if (!isValid)
            {
                Console.WriteLine("Die Anzahl der angegebenen Argumente ist falsch! (pro einzutragender Zahl sind 3 Werte einzugeben.)");
                return false;
            }
            // Weiters prüfen ob die einzelnen Argumente richtig sind.

            

            return isValid;
        }

        private static int[,] GenerateSudokuWithArguments(int[] arguments)
        {
            // int[,] sudoku = new int[9, 9];
            int[,] sudoku = new int[9, 9] { 
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            // CLI Argumente 1 2 5 9 1 6 9 9 7 1 1 2
            // sehr schlecht lesbare Lösung
            for (int i = 0; i < arguments.Length/3; i++)
            {
                int row = arguments[0+i*3];
                int column = arguments[1+i*3];
                int value = arguments[2+i*3];
                sudoku[row-1, column-1] = value;
            }

            return sudoku;
        }

        private static int[] GetSpecificBlockFromSudoku(int[,] sudoku, int numberOfBlock)
        {
            int[] specificBlockOfSudoku = new int[9];

            int count = 0;


            // Gets the first block of Sudoku (just a prototype, needs to be extended to get other blocks too)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    specificBlockOfSudoku[count++] = sudoku[i, j];
                }

            }

            return specificBlockOfSudoku;
        }

        private static bool Contains(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return true;
            }

            return false;
        }
        private static bool ContainsWithinRow(int [,] twoDimensionalArray, int indexOfRow, int value)
        {
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                if (twoDimensionalArray[indexOfRow, i] == value)
                    return true;
            }

            return false;
        }

        private static bool ContainsWithinColumn(int[,] twoDimensionalArray, int indexofColumn, int value)
        {
            for (int i = 0; i < twoDimensionalArray.GetLength(1); i++)
            {
                if (twoDimensionalArray[i, indexofColumn] == value)
                    return true;
            }

            return false;
        }
        private static void PrintSudoku(int[,] sudoku)
        {
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"|{sudoku[i,0]}|{sudoku[i, 1]}|{sudoku[i, 2]}| |{sudoku[i, 3]}|{sudoku[i, 4]}|{sudoku[i, 5]}| |{sudoku[i, 6]}|{sudoku[i, 7]}|{sudoku[i, 8]}|");
                if (i==2 || i== 5)
                    Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
