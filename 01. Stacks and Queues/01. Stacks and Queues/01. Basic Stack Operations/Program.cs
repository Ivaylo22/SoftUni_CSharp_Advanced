using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = cmd[0];
            int s = cmd[1];
            int x = cmd[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++) { 
                stack.Push(input[i]);
            }
            for (int i = 0; i < s; i++) {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else {
                Console.WriteLine("0");
            }
        }
    }
}

