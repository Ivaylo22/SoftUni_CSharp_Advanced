using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> result = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in line) 
                {
                    result.Add(s);
                }
            }

            var sortedSet = result.OrderBy(s => s);

            Console.WriteLine(string.Join(' ', sortedSet)) ;
        }
    }
}
