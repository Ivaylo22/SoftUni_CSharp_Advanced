using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int availableQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            bool notCompleted = false;
            int queueSize = queue.Count;

            for (int i = 0; i < queueSize; i++) {
                int numberToCheck = queue.Peek();
                if (availableQuantity >= numberToCheck)
                {
                    availableQuantity -= numberToCheck;
                    queue.Dequeue();
                }
                else {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    notCompleted = true;
                    break;
                }
            }
            if (!notCompleted) {
                Console.WriteLine("Orders complete");
            }
        }
    }
}

