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
                Name = "Leon",
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

            List<Animal> animals = new List<Animal>() { bob, leon, john };

            foreach (Animal animal in animals)
            {
                DisplayFoodsEaten(animal);
            }

            Console.ReadKey();

            DisplayLookAtAnimals(animals);
        }

        public static void DisplayFoodsEaten(Animal animal)
        {
            Console.WriteLine(animal.Name + " eats the following: ");
            if (animal is IHerbivore)
            {
                var theAnimal = animal as IHerbivore;
                Console.WriteLine($"Vegetation: {theAnimal.VegetationEaten[0]} and {theAnimal.VegetationEaten[1]}.");
            }
            if (animal is ICarnivore)
            {
                var theAnimal = animal as ICarnivore;
                Console.WriteLine($"Animals: {theAnimal.AnimalsEaten[0]} and {theAnimal.AnimalsEaten[1]}.");
            }
            Console.WriteLine();
        }

        public static void DisplayLookAtAnimals(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("You are in a large room and notice the following animals.");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($" You notice a {animal.GetType().Name}. It has {animal.NumberOfLegs} legs.");
                if (animal is Lion)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t************************************");
                    Console.WriteLine("\t\t* You have been eaten by a lion!!! *");
                    Console.WriteLine("\t\t************************************");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
