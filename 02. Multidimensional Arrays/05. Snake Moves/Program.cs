using System;
using System.Linq;
using System.Text;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            char[,] matrix = new char[rows, cols];

            string input = Console.ReadLine();

            FillMatrix(matrix, input);

            PrintMatrix(matrix);
        }

        private static void FillMatrix(char[,] matrix, string input)
        {
            char[] chars = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            while (sb.Length <= matrix.GetLength(0) * matrix.GetLength(1)) { 
                sb.Append(chars);
            }

            int i = 0;
            for (int row = 0; row < matrix.GetLength(0); row++) 
            {
                if (row % 2 == 0 || row == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1) ; col++)
                    {
                        matrix[row, col] = sb[i];
                        i++;
                    }               
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >=0; col--)
                    {
                        matrix[row, col] = sb[i];
                        i++;
                    }
                }

            }
               
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");

                }
                Console.WriteLine();
            }
        }
    }
}
