using System.Collections.Generic;

namespace Demo_Interfaces_Animals
{
    public class Horse : Animal, IHerbivore
    {
        public override string Name { get; set; }
        public override int NumberOfLegs { get; set; }
        public override string Habitat { get; set; }
        public List<string> VegetationEaten { get; set; }
    }
}
