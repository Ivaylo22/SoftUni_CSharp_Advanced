using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int rackCounter = 1;
            int currentCapacity = capacity;

            Stack<int> stack = new Stack<int>(clothes);
            int stackSize = stack.Count;

            for (int i = 0; i < stackSize; i++) {
                int clothToChange = stack.Peek();
                if (currentCapacity >= clothToChange)
                {
                    currentCapacity -= clothToChange;
                    stack.Pop();
                }
                else { 
                    currentCapacity = capacity;
                    rackCounter++;
                    currentCapacity -= clothToChange;
                    stack.Pop();
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
