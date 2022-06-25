using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                {"Sink",0},
                {"Oven", 0},
                {"Countertop", 0},
                {"Wall", 0},
                {"Floor", 0}
            };

            double[] whiteInts = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Stack<double> whites = new Stack<double>(whiteInts);

            double[] greyInts = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Queue<double> greys = new Queue<double>(greyInts);


            while (true) {
                double currentWhite = whites.Peek();
                double currentGrey = greys.Peek();

                if (currentWhite == currentGrey)
                {
                    double sum = currentWhite + currentGrey;
                    if (sum == 40)
                    {
                        locations["Sink"]++;
                    }
                    else if (sum == 50)
                    {
                        locations["Oven"]++;
                    }
                    else if (sum == 60)
                    {
                        locations["Countertop"]++;
                    }
                    else if (sum == 70)
                    {
                        locations["Wall"]++;
                    }
                    else
                    {
                        locations["Floor"]++;
                    }
                    whites.Pop();
                    greys.Dequeue();
                }
                else {
                    double dividedWhite = currentWhite / 2;
                    whites.Pop();
                    whites.Push(dividedWhite);
                    greys.Dequeue();
                    greys.Enqueue(currentGrey);           
                }

                if (whites.Count == 0 || greys.Count == 0)
                    break;
            }

            

            if(whites.Count == 0)
                Console.WriteLine("White tiles left: none");
            else
                Console.WriteLine($"White tiles left: {string.Join(", ", whites)}");
            if (greys.Count == 0)
                Console.WriteLine("Grey tiles left: none");
            else
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greys)}");

            foreach (var location in locations.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
            {
                if(location.Value != 0)
                    Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
