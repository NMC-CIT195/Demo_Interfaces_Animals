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

            //
            // Create a list of the base class Animal to hold objects from 
            // all of the derived classes.
            //
            List<Animal> animals = new List<Animal>() { bob, leon, john };

            //
            // Loop through the list of animals and display the foods they eat.
            //
            Console.WriteLine("A list of animals and what they eat.\n");
            foreach (Animal animal in animals)
            {
                DisplayFoodsEaten(animal);
            }

            Console.ReadKey();

            //
            // Display a list of all animals in the room and
            // the number of legs they have.
            // Display a special message when looking at a lion.
            //
            DisplayAnimalsISee(animals);
        }

        /// <summary>
        /// Display the list of foods eaten by type for each animal.
        /// Note that to have a concise example, list items are referenced by index number.
        /// A "foreach" loop should be used to display all list items.
        /// </summary>
        /// <param name="animal">list of animals</param>
        public static void DisplayFoodsEaten(Animal animal)
        {
            Console.WriteLine(animal.Name + " eats the following: ");
            if (animal is IHerbivore)
            {
                var theAnimal = animal as IHerbivore;
                Console.WriteLine($"\tVegetation: {theAnimal.VegetationEaten[0]} and {theAnimal.VegetationEaten[1]}.");
            }
            if (animal is ICarnivore)
            {
                var theAnimal = animal as ICarnivore;
                Console.WriteLine($"\tAnimals: {theAnimal.AnimalsEaten[0]} and {theAnimal.AnimalsEaten[1]}.");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Display all animals in the list of animals and flag when
        /// a lion is displayed with a special message.
        /// </summary>
        /// <param name="animals">list of animals</param>
        public static void DisplayAnimalsISee(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("You are in a large room and notice the following animals.");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"\tYou notice a {animal.GetType().Name}. It has {animal.NumberOfLegs} legs.");
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
