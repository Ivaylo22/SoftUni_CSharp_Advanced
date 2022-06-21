using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double engineSpeed = double.Parse(input[1]);
                double enginePower = double.Parse(input[2]);
                double cargoWeight = double.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);
                List<Tire> tires = new List<Tire>();
                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);


                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command.Equals("fragile"))
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type.Equals("fragile"))
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Presure < 1)
                            {
                                Console.WriteLine(car.Model);
                                break;
                            }
                        }
                    }
                }

            }

            else if (command.Equals("flammable")) 
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type.Equals("flammable") && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);     
                    }
                }
            }
        }
    }
}
