using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] waterInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Queue<double> waters = new Queue<double>(waterInput);

            double[] flourInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Stack<double> flours = new Stack<double>(flourInput);
            var products = new Dictionary<string, int>();

            while (waters.Count != 0 && flours.Count != 0) {
                bool isValid = true;
                double flourLeft = 0;
                double currentWater = waters.Peek();
                double currentFlour = flours.Peek();

                double sum = currentFlour + currentWater;

                double percentWater = currentWater * 100 / sum;
                double percentFlour = currentFlour * 100 / sum;

                if (percentWater == 40 && percentFlour == 60) {
                    if (!products.Keys.Contains("Muffin"))
                    {
                        products.Add("Muffin", 0);
                    }
                    products["Muffin"]++;
                }

                else if (percentWater == 30 && percentFlour == 70)
                {
                    if (!products.Keys.Contains("Baguette"))
                    {
                        products.Add("Baguette", 0);
                    }
                    products["Baguette"]++;
                }

                else if (percentWater == 20 && percentFlour == 80)
                {
                    if (!products.Keys.Contains("Bagel"))
                    {
                        products.Add("Bagel", 0);
                    }
                    products["Bagel"]++;
                }

                else if (percentWater == 50 && percentFlour == 50) 
                {             
                    if (!products.Keys.Contains("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }
                    products["Croissant"]++;                   
                }

                else 
                {
                    if (!products.Keys.Contains("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }
                    flourLeft = currentFlour - currentWater;
                    products["Croissant"]++;
                    isValid = false;
                    flours.Pop();
                    flours.Push(flourLeft);
                }

                waters.Dequeue();
                flours.Pop();
                if (!isValid)
                    flours.Push(flourLeft);
            }

            foreach (string product in products.Keys.OrderByDescending(product => products[product]).ThenBy(product => product)) {
                Console.WriteLine($"{product}: {products[product]}");
            }
            if (waters.Count == 0) 
                Console.WriteLine("Water left: None");
            else
                Console.WriteLine($"Water left: {string.Join(", ", waters)}");
            if (flours.Count == 0)
                Console.WriteLine("Flour left: None");
            else
                Console.WriteLine($"Flour left: {string.Join(", ", flours)}");
        }
    }
}
