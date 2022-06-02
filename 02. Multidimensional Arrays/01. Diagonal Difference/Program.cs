using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            FillMatrix(matrix);
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++) 
                { 
                    int number = matrix[row,col];
                    if (row == col) 
                        firstDiagonal += number;
                    if (row + col == n - 1)
                        secondDiagonal += number;
                }

            }

            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++) 
                { 
                    matrix[row,col] = rowData[col];
                }
            }
        }
    }
}
