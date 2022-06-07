using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pairs = new Dictionary<int, int>();

            for (int i = 0; i < n; i++) 
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                if (!pairs.ContainsKey(numberToAdd))
                    pairs[numberToAdd] = 0;
                pairs[numberToAdd]++;
            }

            foreach (var pair in pairs)
            {
                if (pair.Value % 2 == 0) { 
                    Console.WriteLine(pair.Key);
                    break;
                }
            }
        }
    }
}
