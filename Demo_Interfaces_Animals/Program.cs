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
        }
    }
}
