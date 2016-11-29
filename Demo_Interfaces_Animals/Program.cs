using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse bob = new Horse()
            {
                Name = "Bob",
                NumberOfLegs = 4,
                Habitat = "Barnyard",
                VegetationEaten = new List<string>() { "Grass", "Hay" }
            };

            Lion leon = new Lion()
            {
                Name = "leon",
                NumberOfLegs = 4,
                Habitat = "Grasslands",
                AnimalsEaten = new List<string>() { "Deer", "Slow People" }
            };

            Human john = new Human()
            {
                Name = "John",
                NumberOfLegs = 2,
                Habitat = "Small Brewpubs",
                VegetationEaten = new List<string>() { "Apples", "Lettuce" },
                AnimalsEaten = new List<string>() { "Pig", "Shrimp" }
            };

            Console.Write(bob.Name + " eats the following ");
            if (bob is IHerbivore)
            {
                Console.WriteLine($"vegetation: {bob.VegetationEaten[0]} and {bob.VegetationEaten[1]}.");
            }

            Console.ReadKey();
        }
    }
}
