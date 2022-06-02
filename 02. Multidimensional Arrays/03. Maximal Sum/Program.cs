using System;
using System.Linq;

namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;
            int currentSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            FillMatrix(matrix);

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum) 
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }                 
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            int rowBorder = maxRow + 2;
            int colBorder = maxCol + 2;

            for (int row = maxRow; row <= rowBorder; row++) {
                for (int col = maxCol; col <= colBorder; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
