using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Animals
{
    public interface IHerbivore
    {
        List<string> VegetationEaten { get; set; }
    }
}
