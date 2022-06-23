using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //var list = new List<double>();

            //for (int i = 0; i < n; i++)
            //{
            //    var input = double.Parse(Console.ReadLine());
            //    list.Add(input);
            //}

            //var box = new Box<double>(list);
            //var elementToCompare = double.Parse(Console.ReadLine());

            //var count = box.CountOfGreater(list, elementToCompare);
            //Console.WriteLine(count);

            string[] nameCity = Console.ReadLine().Split();
            string fullName = $"{nameCity[0]} {nameCity[1]}";
            string address = nameCity[2];
            string town = nameCity.Length > 4 ? $"{nameCity[3]} {nameCity[4]}" : $"{nameCity[3]}";

            string[] nameBeer = Console.ReadLine().Split();
            string name = nameBeer[0];
            int beer = int.Parse(nameBeer[1]);
            var isDrunk = nameBeer[2] == "drunk" ? true : false;

            string[] nameBalanceBank = Console.ReadLine().Split();
            string namePerson = nameBalanceBank[0]; 
            double balance = double.Parse(nameBalanceBank[1]);
            string nameBank = nameBalanceBank[2];

            Tuple<string, string, string> tuple1 = new Tuple<string, string, string>(fullName, address, town);
            Tuple<string, int, bool> tuple2 = new Tuple<string, int, bool>(name, beer, isDrunk);
            Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(namePerson, balance, nameBank);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);

        }
    }
}
