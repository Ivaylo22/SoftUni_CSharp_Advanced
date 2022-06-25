using System;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int vankoRow = 0;
            int vankoCol = 0;
            int rodsCount = 0;
            bool gotElecrocuted = false;
            int finalHoles = 0;


            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'V') 
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }


            while (true) 
            {
                string direciton = Console.ReadLine();

                if (direciton == "up") 
                {
                    vankoRow--;
                    if (vankoRow < 0) 
                    {
                        
                        vankoRow++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == '-') 
                    { 
                        matrix[vankoRow+1, vankoCol] = '*';
                    }

                    if (matrix[vankoRow, vankoCol] == 'R') 
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        vankoRow++;
                        rodsCount++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == 'C') 
                    {
                        matrix[vankoRow, vankoCol] = 'E';
                        matrix[vankoRow + 1, vankoCol] = '*';
                        gotElecrocuted = true;
                        break;
                    }

                    if (matrix[vankoRow, vankoCol] == '*') 
                    {
                        matrix[vankoRow+1, vankoCol] = '*';
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    }
                }

                else if (direciton == "down")
                {
                    vankoRow++;
                    if (vankoRow > n - 1)
                    {
                        vankoRow--;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow - 1, vankoCol] = '*';
                    }

                    if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        vankoRow--;
                        rodsCount++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        matrix[vankoRow, vankoCol] = 'E';
                        matrix[vankoRow - 1, vankoCol] = '*';
                        gotElecrocuted = true;
                        break;
                    }

                    if (matrix[vankoRow, vankoCol] == '*')
                    {
                        matrix[vankoRow - 1, vankoCol] = '*';
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    }
                }

                else if (direciton == "right")
                {
                    vankoCol++;
                    if (vankoCol > n - 1)
                    {
                        vankoCol--;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow , vankoCol-1] = '*';
                    }

                    if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        vankoCol--;
                        rodsCount++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        matrix[vankoRow, vankoCol] = 'E';
                        matrix[vankoRow, vankoCol - 1] = '*';
                        gotElecrocuted = true;
                        break;
                    }

                    if (matrix[vankoRow, vankoCol] == '*')
                    {
                        matrix[vankoRow, vankoCol - 1] = '*'; 
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    }
                }

                else if (direciton == "left")
                {
                    vankoCol--;
                    if (vankoCol < 0)
                    {
                        vankoCol++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == '-')
                    {
                        matrix[vankoRow, vankoCol + 1] = '*';
                    }

                    if (matrix[vankoRow, vankoCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        vankoCol++;
                        rodsCount++;
                        continue;
                    }

                    if (matrix[vankoRow, vankoCol] == 'C')
                    {
                        
                        matrix[vankoRow, vankoCol] = 'E';
                        matrix[vankoRow, vankoCol + 1] = '*';
                        gotElecrocuted = true;
                        break;
                    }

                    if (matrix[vankoRow, vankoCol] == '*')
                    {
                        matrix[vankoRow, vankoCol+ 1] = '*';
                        Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    }
                }

                if (direciton == "End")
                {
                    matrix[vankoRow, vankoCol] = 'V';
                    break;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((char)matrix[i, j] == 'E' || (char)matrix[i, j] == '*' || (char)matrix[i, j] == 'V')
                        finalHoles++;
                }
            }

            if (gotElecrocuted)
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {finalHoles} hole(s).");
            else
                Console.WriteLine($"Vanko managed to make {finalHoles} hole(s) and he hit only {rodsCount} rod(s).");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((char)matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
