using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] colorCloth = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color = colorCloth[0];
                string[] allClothes = colorCloth[1].Split(",");

                if (!clothes.ContainsKey(color))
                    clothes.Add(color, new Dictionary<string, int>());

                foreach (var cloth in allClothes) {
                    if (!clothes[color].ContainsKey(cloth))
                        clothes[color][cloth] = 0;
                    clothes[color][cloth]++;
                }
                
            }

            string[] checkLine = Console.ReadLine().Split();
            string colorToSearch = checkLine[0];
            string dressToSeach = checkLine[1];

            foreach (var colorDress in clothes)
            {
                Console.WriteLine($"{colorDress.Key} clothes:");
                foreach (var dressCount in colorDress.Value)
                {
                    if(colorDress.Key.Equals(colorToSearch) && dressCount.Key.Equals(dressToSeach))
                        Console.WriteLine($"* {dressCount.Key} - {dressCount.Value} (found!)");
                    else
                        Console.WriteLine($"* {dressCount.Key} - {dressCount.Value}");

                }
            }

        }
    }
}
