using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < n; i++) { 
                int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = cmd[0];
                if (command == 1)
                {
                    int numberToPush = cmd[1];
                    stack.Push(numberToPush);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4 && stack.Count > 0) {
                    Console.WriteLine(stack.Min());
                }
            }
            int[] finalArray = stack.ToArray();
            Console.WriteLine(string.Join(", ", finalArray));
        }
    }
}
