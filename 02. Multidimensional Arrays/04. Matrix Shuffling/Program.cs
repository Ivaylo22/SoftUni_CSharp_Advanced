using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix);

            while (true) 
            {
                bool isValid = true;
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0].Equals("END"))
                    break;

                if (ValidateInput(input, matrix)) {
                    string firstValue = matrix[int.Parse(input[1]), int.Parse(input[2])];
                    string secondValue = matrix[int.Parse(input[3]), int.Parse(input[4])];
                    string currentValue = firstValue;

                    matrix[int.Parse(input[1]), int.Parse(input[2])] = secondValue;
                    matrix[int.Parse(input[3]), int.Parse(input[4])] = currentValue;

                    PrintMatrix(matrix);
                }
                else
                    Console.WriteLine("Invalid input!");

            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool ValidateInput(string[] input, string[,] matrix)
        {
            string command = input[0];
            

            if (!command.Equals("swap") || input.Length != 5) 
            {
                return false;
            }
            int rowFirst = int.Parse(input[1]);
            int colFirst = int.Parse(input[2]);
            int rowSecond = int.Parse(input[3]);
            int colSecond = int.Parse(input[4]);

            if (rowFirst < 0 || colFirst < 0 || rowSecond < 0 || colSecond < 0 ||
                rowFirst >= matrix.GetLength(0) || colFirst >= matrix.GetLength(1) ||
                rowSecond >= matrix.GetLength(0) || colSecond >= matrix.GetLength(1))
                return false;


            return true;
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
