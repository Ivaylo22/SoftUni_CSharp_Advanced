using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = line[0];
            int m = line[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();


            for (int i = 0; i < n; i++) 
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                set1.Add(numberToAdd);
            }

            for (int i = 0; i < m; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                set2.Add(numberToAdd);
            }

            foreach (var num in set1) 
            {
                if(set2.Contains(num))
                    result.Add(num);
            }

            string resultString = string.Join(" ", result);
            Console.WriteLine(resultString);
        }
    }
}
