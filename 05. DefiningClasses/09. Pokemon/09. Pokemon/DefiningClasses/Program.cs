using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Trainer> listTrainers = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] data = input.Split();

                string trainerName = data[0];
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer currentTrainer = new Trainer();

                bool checkTrainer = listTrainers.Any(n => n.Name == trainerName);

                if (!checkTrainer)
                {
                    currentTrainer.Name = trainerName;
                    currentTrainer.collectionPokemon.Add(currentPokemon);
                    listTrainers.Add(currentTrainer);
                }
                else
                {
                    foreach (var trainer in listTrainers)
                    {
                        if (trainer.Name == trainerName)
                        {
                            trainer.collectionPokemon.Add(currentPokemon);
                        }
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                switch (command)
                {
                    case "Fire":
                        atacking(listTrainers, command);

                        break;



                    case "Water":
                        atacking(listTrainers, command);
                        break;



                    case "Electricity":
                        atacking(listTrainers, command);
                        break;
                }

                command = Console.ReadLine();
            }


            foreach (var trainer in listTrainers.OrderByDescending(a => a.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.collectionPokemon.Count}");
            }
        }

        private static void atacking(List<Trainer> listTrainers, string command)
        {
            foreach (var trainer in listTrainers)
            {
                bool isTranerHasThatElement = false;
                foreach (var pokemon in trainer.collectionPokemon)
                {
                    if (command == pokemon.Element)
                    {
                        trainer.NumberOfBadges++;
                        isTranerHasThatElement = true;
                        break;
                    }

                }

                if (isTranerHasThatElement == false)
                {
                    // LINQ alternative
                    trainer.collectionPokemon.ForEach(pokemon => pokemon.Health -= 10);
                    trainer.collectionPokemon.RemoveAll(pokemon => pokemon.Health <= 0);


                    // foreach (var pokemon in trainer.collectionPokemon)
                    // {
                    //     pokemon.Health -= 10;
                    //     if (pokemon.Health <= 0)
                    //     {
                    //         EXCEPTION => When removing/changing collection    
                    //         trainer.collectionPokemon.Remove(pokemon);
                    //         if(trainer.collectionPokemon.Count == 0)
                    //         {
                    //             break;
                    //         }
                    //     }
                    // }
                }
            }
        }
    
    }
}
