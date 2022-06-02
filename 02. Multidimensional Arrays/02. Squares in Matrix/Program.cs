using System;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            string[,] matrix = new string[rows, cols];
            int br = 0;

            FillMatrix(matrix);

            for (int row = 0; row < rows - 1; row++) 
            {
                for (int col = 0; col < cols - 1 ; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]) 
                    {
                        br++;
                    }

                }
            }
            Console.WriteLine(br);

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
