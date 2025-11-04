using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public record GalaxyOptions
    {
        public GalaxyOptions(int numberOfPlanets, int numberOfSolarSystems = 1)
        {
            NumberOfPlanets = numberOfPlanets;
            NumberOfSolarSystems = numberOfSolarSystems;
        }

        public int NumberOfPlanets { get; }

        public int NumberOfSolarSystems { get;  }
    }
}
