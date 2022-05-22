using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0) { 
                string command = Console.ReadLine();
                if (command.Contains("Add"))
                {
                    string songName = command.Substring(4);
                    if (!queue.Contains(songName))
                    {
                        queue.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }

                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else if (command == "Play")
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
