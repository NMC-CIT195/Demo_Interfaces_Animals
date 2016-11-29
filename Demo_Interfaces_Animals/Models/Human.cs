using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Animals.Models
{
    public class Human : Animal, IHerbivore, ICarnivore
    {
        public override string Name { get; set; }
        public override int NumberOfLegs { get; set; }
        public override string Habitat { get; set; }
        public List<string> VegetationEaten { get; set; }
        public List<string> AnimalsEaten { get; set; }
    }
}
