using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            var pairs = new Dictionary<char, int>();

            foreach (var character in chars)
            {
                if (!pairs.ContainsKey(character))
                    pairs[character] = 0;
                pairs[character]++;
            }

            foreach (var pair in pairs.OrderBy(x => x.Key)) {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
