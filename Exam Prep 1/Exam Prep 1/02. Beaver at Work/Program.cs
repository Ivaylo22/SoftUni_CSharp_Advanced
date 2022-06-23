using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int beaverRow = 0;
            int beaverCol = 0;
            int totalBranches = 0;
            int currentBranches = 0;
            bool foundAll = false;

            char[,] matrix = new char[n,n];

            Stack<char> branches = new Stack<char>();

            for (int row = 0; row < n; row++)
            {
                char[] chars = Console.ReadLine().Replace(" ", "").ToCharArray();

                for (int col = 0; col < n; col++) { 
                    matrix[row,col] = chars[col];
                    if (matrix[row, col].Equals('B'))
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                    else if (char.IsLower(matrix[row, col])) {
                        totalBranches++;
                    }
                }
            }

            string input = Console.ReadLine();
            while (input != "end") 
            {
                if (input.Equals("up")) {
                    matrix[beaverRow, beaverCol] = '-';
                    beaverRow--;
                    if (beaverRow < 0)
                    {
                        if(branches.Count > 0)
                            branches.Pop();
                        beaverRow++;
                    }
                    else if (char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        branches.Push(matrix[beaverRow, beaverCol]);
                        currentBranches++;
                        matrix[beaverRow, beaverCol] = '-';
                    }
                    else if (matrix[beaverRow, beaverCol] == 'F') 
                    {
                        matrix[beaverRow, beaverCol] = '-';
                        if (beaverRow == 0)
                        {
                            while (beaverRow < matrix.GetLength(0) - 1)
                                beaverRow++;
                        }
                        else
                        {
                            while (beaverRow >= 0)
                                beaverRow--;
                        }

                        if (char.IsLower(matrix[beaverRow, beaverCol]))
                        {
                            branches.Push(matrix[beaverRow, beaverCol]);
                            currentBranches++;
                        }
                        matrix[beaverRow, beaverCol] = '-';
                    }
                }

                if (input.Equals("down"))
                {
                    matrix[beaverRow, beaverCol] = '-';

                    beaverRow++;
                    if (beaverRow > matrix.GetLength(0) - 1)
                    {
                        if (branches.Count > 0)
                            branches.Pop();
                        beaverRow--;
                    }
                    else if (char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        branches.Push(matrix[beaverRow, beaverCol]);
                        currentBranches++;
                        matrix[beaverRow, beaverCol] = '-';
                    }
                    else if (matrix[beaverRow, beaverCol].Equals('F'))
                    {
                        matrix[beaverRow, beaverCol] = '-';
                        if (beaverRow == matrix.GetLength(0) - 1)
                        {
                            while (beaverRow >= 0)
                                beaverRow--;
                        }
                        else
                        {
                            while (beaverRow < matrix.GetLength(0))
                                beaverRow++;
                        }
                    }
                }

                if (input.Equals("right"))
                {
                    matrix[beaverRow, beaverCol] = '-';

                    beaverCol++;
                    if (beaverCol > matrix.GetLength(1) - 1)
                    {
                        if (branches.Count > 0)
                            branches.Pop();
                        beaverCol--;
                    }
                    else if (char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        branches.Push(matrix[beaverRow, beaverCol]);
                        currentBranches++;
                        matrix[beaverRow, beaverCol] = '-';
                    }
                    else if (matrix[beaverRow, beaverCol].Equals('F'))
                    {
                        matrix[beaverRow, beaverCol] = '-';
                        if (beaverCol == matrix.GetLength(1) - 1)
                        {
                            while (beaverCol >= 0)
                                beaverCol--;
                        }
                        else
                        {
                            while (beaverCol < matrix.GetLength(1))
                                beaverCol++;
                        }
                    }
                }

                if (input.Equals("left"))
                {
                    matrix[beaverRow, beaverCol] = '-';

                    beaverCol--;
                    if (beaverCol < 0)
                    {
                        if (branches.Count > 0)
                            branches.Pop();
                        beaverCol++;
                    }
                    else if (char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        branches.Push(matrix[beaverRow, beaverCol]);
                        currentBranches++;
                        matrix[beaverRow, beaverCol] = '-';
                    }
                    else if (matrix[beaverRow, beaverCol].Equals('F'))
                    {
                        matrix[beaverRow, beaverCol] = '-';
                        if (beaverCol == 0)
                        {
                            while (beaverCol < matrix.GetLength(1))
                                beaverCol++;
                        }
                        else
                        {
                            while (beaverCol >= 0)
                                beaverCol--;
                        }
                    }
                }
                matrix[beaverRow, beaverCol] = 'B';
                if (currentBranches == totalBranches) { 
                    foundAll = true;
                    break;
                }

                input = Console.ReadLine();
            }
            int branchesLeft = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (char.IsLower(matrix[row, col]))
                        branchesLeft++;
                }
            }
            List<char> branchesList = new List<char>(branches);
            branchesList.Reverse();

            if (foundAll)
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branchesList)}.");
            else
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesLeft} branches left.");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
