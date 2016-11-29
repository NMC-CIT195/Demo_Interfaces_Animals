using System.Collections.Generic;

namespace Demo_Interfaces_Animals
{
    public class Lion : Animal, ICarnivore
    {
        public override string Name { get; set; }
        public override int NumberOfLegs { get; set; }
        public override string Habitat { get; set; }
        public List<string> AnimalsEaten { get; set; }
    }
}
